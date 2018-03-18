using System;
using System.Collections.Generic;
using System.Linq;
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
        
    }
}
