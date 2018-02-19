using LmycDataLib;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LmycWebSite.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;

        public HomeController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AnonymousIndex", "Home");
            }
            else
            {
                if (isAdminUser())
                {
                    return View();
                }
                else
                {
                    return View();
                }
            }
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

        public ActionResult AdminIndex()
        {
            ViewBag.Message = "Welcome admin.";

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

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}