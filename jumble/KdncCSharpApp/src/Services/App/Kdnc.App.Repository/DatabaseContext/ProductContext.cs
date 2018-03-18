using Kdnc.App.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Kdnc.App.Repository.DatabaseContext
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
           : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
