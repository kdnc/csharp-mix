using Kdnc.App.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Kdnc.App.Repository.DatabaseContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
           : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
