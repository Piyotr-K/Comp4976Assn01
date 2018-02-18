using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LmycWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AnonymousIndex", "Home");
            }
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AnonymousIndex()
        {
            ViewBag.Message = "Welcome stranger.";

            return View();
        }

        public ActionResult AnonymousContact()
        {
            ViewBag.Message = "Find Us";

            return View();
        }

        public ActionResult Contact()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AnonymousContact", "Home");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}