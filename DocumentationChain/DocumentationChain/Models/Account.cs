using DocumentationChain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class Account
    {
        public Account(int ID, string name, string price)
        {
            Id = ID;
            Name = name;
            Price = price;
        }
        public Account()
        {
      
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

       
    }
}
