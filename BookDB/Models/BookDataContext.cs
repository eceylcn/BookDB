using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookDB.Models
{
    public class BookDataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server= DESKTOP-GLBJS43\\SQLEXPRESS; Database = book_database; Trusted_Connection= True;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasOne<publisher>(b => b.BookPublisher).WithMany(o => o.Books)
                .HasForeignKey(b => b.BookPublisherId);
        }
    }

    
}
