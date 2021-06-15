using DocumentationChain.Data;
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
    }
}
