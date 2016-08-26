using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.DAL;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> students = null;
            using (var context = new SchoolContext())
            {
                students = context.Students.ToList();
            }
            return View(students);
        }
    }
}