using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.Application.Models;
using Kdnc.App.Application.Services;
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
        private readonly IProductsApplicationService productApplicationService;

        public ProductController(IProductsApplicationService productApplicationService)
        {
            this.productApplicationService = productApplicationService;
        }

        // GET api/product
//        [HttpGet]
//        public IEnumerable<Product> GetAll()
//        {
//            return repo.GetAll();
//        }

        // POST api/product
        [HttpPost]
        public IActionResult AddProduct([FromBody]ProductDto product)
        {
            productApplicationService.SaveProduct(product);
            return Ok();
        }
    }
}
