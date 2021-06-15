using DocumentationChain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Data
{
    public static class DBInitializer
    {
        
        public static void Initialize(DocumentationContext context)
        {
            context.Database.EnsureCreated();

            /*
            if (context.DocumentationTable.Any())
            {
                return;   // DB has been seeded
            }

            var test = new DocumentationTable[]
            {
                new DocumentationTable{Id = 1, FileName="OlliePDF",SecuirtyPhase="56789"},
                 new DocumentationTable{Id = 2,FileName="JamesPDF",SecuirtyPhase="534535"}
              

            };
            foreach (DocumentationTable s in test)
            {
                context.DocumentationTable.Add(s);
            }
        
            */

           /*
            if (context.Account.Any())
            {
                return;   // DB has been seeded
            }

            var test = new Account[]
            {
                new Account{Id = 1,Name="Ollie",Price="56789"},            
            };
            foreach (Account s in test)
            {
                context.Account.Add(s);
            }

            

            context.SaveChanges();
           */
        }


    }
}
