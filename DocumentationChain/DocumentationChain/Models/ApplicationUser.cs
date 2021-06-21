using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Balance { get; set; }

        public void SetBalance(float newBalance)
        {      
            Balance = newBalance;
        }

        public float GetBalance()
        {
            return Balance; 
        }

    }
}
