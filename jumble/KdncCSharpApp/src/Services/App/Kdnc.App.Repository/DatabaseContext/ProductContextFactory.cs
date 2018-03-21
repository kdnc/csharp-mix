using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Kdnc.App.Repository.DatabaseContext
{
    public class ProductContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContextFactory()
        {
        }

        public ProductContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProductContext>();
            builder.UseSqlServer(
                "Data Source=SLLAP0130\\SQLEXPRESS;Initial Catalog=KdncECommerceAppDB;Integrated Security=True;MultipleActiveResultSets=true;");

            return new ProductContext(builder.Options);
        }

    }
}
