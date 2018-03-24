using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.API.Repositories;
using Kdnc.App.Domain.DataAccess;
using Kdnc.App.Domain.Models;
using Kdnc.App.Repository.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kdnc.App.API.Controllers
{
//    [Authorize]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        // GET api/product
//        [HttpGet]
//        public IEnumerable<Product> GetAll()
//        {
//            return repo.GetAll();
//        }

        // POST api/product
        [HttpPost]
        public IActionResult AddProduct([FromBody]Product product)
        {
            repo.AddProduct(product);
            return Ok();
        }
    }
}
