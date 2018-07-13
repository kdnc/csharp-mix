using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.Application.Services;
using Kdnc.App.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kdnc.App.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Samurais")]
    public class SamuraisController : Controller
    {
        private readonly ISamuraisApplicationService _samuraisApplicationService;

        public SamuraisController(ISamuraisApplicationService samuraisApplicationService)
        {
            this._samuraisApplicationService = samuraisApplicationService;
        }

        // POST: Samurais
        [HttpPost]
        public IActionResult Post([FromBody] SamuraiDto samuraiDto)
        {
            if (!ModelState.IsValid || samuraiDto == null)
            {
                return BadRequest(ModelState);
            }

            this._samuraisApplicationService.CreateSamurai(samuraiDto);
            return Created("api/Samurais", samuraiDto);
        }
    }
}