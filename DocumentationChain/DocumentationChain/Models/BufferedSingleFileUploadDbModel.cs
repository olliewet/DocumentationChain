using DocumentationChain.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class BufferedSingleFileUploadDbModel : PageModel
    {
        private readonly DocumentationContext _context = null;
        public BufferedSingleFileUploadDbModel(DocumentationContext context)
        {
            _context = context;
        }

        public BufferedSingleFileUploadDbModel()
        {

        }

        [BindProperty]
        public BufferedSingleFileUploadDb FileUpload { get; set; }


        public async void UploadToDatabase(File file)
        {
            _context.Add(file);
            await _context.SaveChangesAsync();
        }


        public class BufferedSingleFileUploadDb
        {
            [Required]
            [Display(Name = "File")]
            public IFormFile FormFile { get; set; }
        }
    }
}
