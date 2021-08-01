using DocumentationChain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationChain.Data
{
    public class DocumentationContext: DbContext
    {  
        public DocumentationContext(DbContextOptions<DocumentationContext> options) : base(options)
        {

        }

        public DbSet<DocumentationTable> DocumentationTable { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<ThemeTesting> ThemeTesting { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //modelBuilder.Entity<DocumentationTable>().ToTable("DocumentationTable");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<File>().ToTable("File");
            modelBuilder.Entity<ThemeTesting>().ToTable("ThemeTesting");
        }
    }
}
