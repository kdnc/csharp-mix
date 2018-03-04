using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.Web.Api;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kdnc.App.Web.Controllers
{
    [Authorize]
    public class ValueController: Controller
    {
        private readonly ValueApiService _valueService;

        public ValueController(ValueApiService valueService)
        {
            this._valueService = valueService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Value view";
            return View(await _valueService.GetAll());
        }
    }
}
