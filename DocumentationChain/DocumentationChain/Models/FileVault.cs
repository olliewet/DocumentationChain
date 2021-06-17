using DocumentationChain.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class FileVault
    {
        private readonly DocumentationContext _context = null;
        public FileVault(DocumentationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds File to Database 
        /// </summary>
        /// <param name="file"></param>
        public async void UploadToDatabase(File file)
        {
            _context.Add(file);
            await _context.SaveChangesAsync();
        }


        /// <summary>
        /// Querys through database context to find a file assoicated to the users security Phase
        /// The selected file is returned
        /// </summary>
        /// <param name="SecPhase"></param>
        /// <returns></returns>
        public File DownLoadFile(string SecPhase)
        {           
            var tempFile = _context.File.Where(w => w.SecPhase == SecPhase).FirstOrDefault();          
            return new File(tempFile.Id, tempFile.Content, tempFile.SecPhase);
        }

        /// <summary>
        /// Stores the whole database as a List which is returned 
        /// </summary>
        /// <returns></returns>
        private List<File> GetFileList()
        {
            List<File> DetList = new List<File>();
            var TempList = _context.File;
            foreach(File f in TempList)
            {
                DetList.Add(f);
            }       
            return DetList;
        }

    }
}
