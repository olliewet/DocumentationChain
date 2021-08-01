using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class ThemeTesting
    {
        public ThemeTesting()
        {

        }
        public ThemeTesting(int id , string _themeID, string _pageID, int _index, string _title, string _content, string _style)
        {
            Id = id;
            ThemeID = _themeID;
            PageID = _pageID;
            Index = _index;
            Title = _title;
            Content = _content;
            Style = _style;
        }

        public int Id { get; set; }
        public string ThemeID { get; set; }
        public string PageID { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Style { get; set; }
       
    }
}
