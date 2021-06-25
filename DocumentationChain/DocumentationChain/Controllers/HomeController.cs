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
using File = DocumentationChain.Models.File;

namespace DocumentationChain.Controllers
{
    public class HomeController : Controller
    {
        //Instances 
        private readonly ILogger<HomeController> _logger;
        private readonly AccountVault accountVault = null;
        private readonly FileVault fileVault = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, AccountVault av, FileVault fv, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
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
            return View();
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
                return RedirectToAction("Documents");
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
