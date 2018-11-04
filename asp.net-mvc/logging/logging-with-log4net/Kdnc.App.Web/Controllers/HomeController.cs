using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kdnc.App.Web.Models;
// Kdnc Step 9 - Add following import statement
using log4net;

namespace Kdnc.App.Web.Controllers
{
    public class HomeController : Controller
    {
        // Kdnc Step 10 - Get a reference to the logger
        protected static readonly ILog log = LogManager.GetLogger(typeof(HomeController));

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // Kdnc Step 11 - Log a debug message
            log.DebugFormat("{0,20} {1,20}", "About", "About view requested.");

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
