using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAOS_MVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to SAOS";

            return View();
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Cloud()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Saint Atique";

            return View();
        }
    }
}
