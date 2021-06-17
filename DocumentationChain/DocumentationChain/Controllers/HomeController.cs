using DocumentationChain.Data;
using DocumentationChain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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


        public HomeController(ILogger<HomeController> logger, AccountVault av, FileVault fv)
        {
            accountVault = av;
            fileVault = fv;
            _logger = logger;    
        }

        public IActionResult Index()
        {        
            return View();
        }

        public IActionResult Privacy()
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
            return RedirectToAction("Documents");
        }




        /// <summary>
        /// Used to Download The File that is assoicated to the Security Phase 
        /// File is returned to the browsers PDF Application
        /// </summary>
        /// <param name="secPhase"></param>
        /// <returns></returns>
        [HttpPost]
        public FileResult DownloadFile(string secPhase)
        {

            File _file = new File();
            _file = fileVault.DownLoadFile(secPhase);
            return File(_file.Content, "application/pdf");
        }

        public async Task<IActionResult> StoreDocuments()
        {
            return RedirectToAction("Documents");
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
