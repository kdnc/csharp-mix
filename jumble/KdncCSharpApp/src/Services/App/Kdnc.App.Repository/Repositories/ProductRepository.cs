using System;
using System.Collections.Generic;
using System.Linq;
using Kdnc.App.Domain.DataAccess;
using Kdnc.App.Domain.Models;
using Kdnc.App.Repository.DatabaseContext;

namespace Kdnc.App.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
    //      product.Id = Guid.NewGuid();
            _context.Products.Add(product);
            _context.SaveChanges();
        }

    }
}
