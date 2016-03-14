using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Git_tuesday.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = " git change is done with feature 1 and 2.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page has been updated.";

            return View();
        }
    }
}