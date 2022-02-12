using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string text = "Hello";
            System.IO.File.WriteAllText(@"C:\Users\hoove\Documents\MVCLogs.txt", text);
            List<string> names = new List<string>
            {
                "Jesse",
                "Adam",
                "Brett"
            };

            User user = new User();
            user.Id = 1;
            user.FirstName = "Carter";
            user.LastName = "Thurman";
            user.Age = 20;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}