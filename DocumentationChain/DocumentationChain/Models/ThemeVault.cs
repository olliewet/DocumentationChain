using DocumentationChain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class ThemeVault
    {
        private readonly DocumentationContext _context = null;
        public ThemeVault(DocumentationContext context)
        {
            _context = context;
        }

        public async void UploadToDatabase(ThemeTesting theme)
        {
            _context.Add(theme);
            await _context.SaveChangesAsync();
        }

        public ThemeTesting GetTheme(string themeID)
        {
            var tempTheme = _context.ThemeTesting.Where(w => w.ThemeID == themeID).FirstOrDefault();
            return new ThemeTesting(tempTheme.Id,tempTheme.ThemeID, tempTheme.PageID, tempTheme.Index, tempTheme.Title, tempTheme.Content, tempTheme.Style);   
        }

        public List<ThemeTesting> GetAllContentBoxes()
        {
            List<ThemeTesting> themeList = new List<ThemeTesting>();
            var TempList = _context.ThemeTesting;
            foreach (ThemeTesting t in TempList)
            {
                themeList.Add(t);
            }
            return themeList;
        }

        public List<ThemeTesting> GetAllContentBoxesFromTheme(string themeID)
        {
            List<ThemeTesting> themeList = new List<ThemeTesting>();
            var TempList = _context.ThemeTesting.Where(w => w.ThemeID == themeID);
            foreach (ThemeTesting t in TempList)
            {
                themeList.Add(t);
            }
            return themeList;
        }


    }
}
