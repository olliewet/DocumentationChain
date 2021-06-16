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

        public async void UploadToDatabase(File file)
        {
            _context.Add(file);
            await _context.SaveChangesAsync();
        }

        public void DownloadFileFromDatabase(string SecPhase)
        {
           var DownloadedFile = _context.File.Where(f => f.SecPhase == SecPhase);               
        }

       
        public File DownLoadFile(string SecPhase)
        {


            List<File> ObjFiles = GetFileList();

            var test = _context.File.Where(w => w.SecPhase == SecPhase).FirstOrDefault();

            /*
            var FileById = (from FC in ObjFiles
                            where FC.SecPhase.Equals(SecPhase)
                            select new { FC.Id, FC.Content, FC.SecPhase}).ToList().FirstOrDefault();
            */

            File DownloadedFile = new File();
            DownloadedFile.Id = test.Id;
            DownloadedFile.Content = test.Content;
            DownloadedFile.SecPhase = test.SecPhase;

            return DownloadedFile;

        }

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
