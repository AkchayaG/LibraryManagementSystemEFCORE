using Microsoft.EntityFrameworkCore;
using LibraryManagementSystemEFCORE.Models;

namespace LibraryManagementSystemEFCORE.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LibraryDb;Trusted_Connection=True;");
        }
    }
}