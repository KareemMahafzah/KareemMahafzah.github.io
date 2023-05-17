using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniLink.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "UniLink description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "UniLink contact page.";

            return View();
        }
    }
}