using DocumentationChain.Data;
using DocumentationChain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Security.Cryptography;
using File = DocumentationChain.Models.File;
using System.Text;

namespace DocumentationChain.Controllers
{
    public class HomeController : Controller
    {
        //Instances 
        private readonly ILogger<HomeController> _logger;
        private readonly AccountVault accountVault = null;
        private readonly FileVault fileVault = null;
        private readonly ThemeVault themeVault = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, AccountVault av, FileVault fv, ThemeVault tv,  SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            themeVault = tv;
            accountVault = av;
            fileVault = fv;
            _logger = logger;
            _signManager = signInManager;
            _userManager = userManager;
        }

        /// <summary>
        /// Returns The View Of Index Page
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            await AddingContentBox();
            return View();
        }


        public IActionResult ThemeOne()
        {                
            return View(themeVault.GetAllContentBoxes());
        }

        /// <summary>
        /// Returns User to the Purchase Tokens View
        /// </summary>
        /// <returns></returns>
        public IActionResult PurchaseTokens()
        {
            return View();
        }

        /// <summary>
        /// Sourced From https://stackoverflow.com/a/6839784/13839509
        /// Used To Hash a String, which will be stored in the database 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        /// <summary>
        /// Used to Create a Random String of Words, this will be used instead of the Security Phase
        /// </summary>
        /// <returns></returns>
        public static string GenerateRandomString()
        {
            Random r = new Random();
            List<string> RandomString = new List<string>();
            string[] words = { "man", "rat", "cow", "chicken" , "food" , "pizza" , "car"};
            for (int i = 0; i < 10; i++)
            {
                RandomString.Add(words[r.Next(0, words.Length - 1)]);
            }
            string Something = string.Join(" ", RandomString);
            return Something;
        }

        public async Task AddingContentBox()
        {
            ThemeTesting theme = new ThemeTesting();
            theme.ThemeID = "Health";
            theme.PageID = "PageTwo";
            theme.Index = 2;
            theme.Style = "is-link";
            theme.Title = "Testing Title";
            theme.Content = "Test";
            themeVault.UploadToDatabase(theme);
        }

        /// <summary>
        /// Reads in a list of files and the Security Phase 
        /// The file and the security phase is stored in the database 
        /// Redirection to Document Page
        /// </summary>
        /// <param name="files"></param>
        /// <param name="SecPhase"></param>
        /// <returns></returns>
        public async Task<IActionResult> SettingUploadData(List<IFormFile> files, string SecPhase)
        {
            try
            {
                //Get the Logged In User 
                var user = await _userManager.GetUserAsync(HttpContext.User);

                //Get Balance 
                float balance = user.GetBalance();

                if (balance >= 5)
                {
                    float newBalance = balance - 5;
                    user.SetBalance(newBalance);
                    await _userManager.UpdateAsync(user);

                    long size = files.Sum(f => f.Length);
                    var filePaths = new List<string>();

                    //Implement a Function that generate A Unquie String 
                    GenerateRandomString();

                    //Stores the hash of the secret phase in the database 
                    SecPhase = GetHashString(SecPhase);


                    foreach (var formFile in files)
                    {
                        if (formFile.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await formFile.CopyToAsync(memoryStream);
                                // Upload the file if less than 2 MB
                                if (memoryStream.Length < 2097152)
                                {
                                    var file = new File()
                                    {
                                        Content = memoryStream.ToArray(),
                                        SecPhase = SecPhase
                                    };
                                    fileVault.UploadToDatabase(file);
                                }
                                else
                                {
                                    ModelState.AddModelError("File", "The file is too large.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Not Enough Tokens";
                }
                return RedirectToAction("Documents"); //Return The Random String to the User 
            }
            catch
            {
                return RedirectToAction("Documents");
            }

        }




        /// <summary>
        /// Used to Download The File that is assoicated to the Security Phase 
        /// File is returned to the browsers PDF Application
        /// </summary>
        /// <param name="secPhase"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DownloadFile(string secPhase)
        {
            try
            {
                //New File
                File _file = new File();
                //Getting User and Users Balance                 
                var user = await _userManager.GetUserAsync(HttpContext.User);
                float balance = user.GetBalance();

                //Encrypt the SecPhase 
                secPhase = GetHashString(secPhase);
                //Checking If User Has Enough Balance To Retrieve Document if not
                //Returns Error Through TempData (Need to Change)
                if (balance >= 5)
                {
                    //Sorting out the new Balance and Updating the Database Column
                    float newBalance = balance - 5;
                    user.SetBalance(newBalance);
                    await _userManager.UpdateAsync(user);
                    _file = fileVault.DownLoadFile(secPhase);
                    return File(_file.Content, "application/pdf");
                }
                else
                {
                    TempData["Message"] = "Insufficient funds please Add More Tokens";
                    return RedirectToAction("RetrieveDocuments");
                }
            }
            catch
            {
                TempData["Message"] = "Error";
                return RedirectToAction("RetrieveDocuments");
            }
        }


        public IActionResult RetrieveDocuments()
        {    
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
