using DocumentationChain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Models
{
    public class AccountVault
    {

        private readonly DocumentationContext _context = null; 
        
        public AccountVault(DocumentationContext context)
        {
            _context = context;
        }
        public void AddAccount(Account _account)
        {
            //Student Validation 
            _context.Account.Add(_account);
            _context.SaveChanges();
        }
        public void AddAccount(DocumentationContext context, Account[] _accounts)
        {
            //Student Validation 
            foreach (Account S in _accounts)
            {
                context.Account.Add(S);
            }
            context.SaveChanges();
        }
        public void RemoveAccount(int ID)
        {
            //Student Validation 
            Account temp = new Account();
            temp.Id = ID;
           
            _context.Account.Remove(temp);
            _context.SaveChanges();
        }
        public void RemoveAccount(DocumentationContext context, Account[] _accounts)
        {
            //Student Validation 
            foreach (Account S in _accounts)
            {
                context.Account.Remove(S);
            }
            context.SaveChanges();
        }
        
    }
}
