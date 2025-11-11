using LibraryManagementSystem.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem.Models
{
    public class DbRepo:DbContext
    {
        public DbRepo(DbContextOptions<DbRepo> options):base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Loans> Loans { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
    }
}
