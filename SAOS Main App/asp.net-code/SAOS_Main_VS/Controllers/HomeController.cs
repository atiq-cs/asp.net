using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }
        public ActionResult Cloud()
        {
            return View();
        }
        
        public ActionResult Saint_Atique()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public String GREWords()
        {
            return "This page is still nunder construction!";
        }

    }
}
