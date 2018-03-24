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
        private readonly ProductContext _productContext;

        public ProductRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public Product AddProduct(Product product)
        {
    //      product.Id = Guid.NewGuid();
            _productContext.Products.Add(product);
            int effectedRowCount = _productContext.SaveChanges();
            return product;
        }

    }
}
