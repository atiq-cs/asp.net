using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAOS_MVC4.Controllers
{
    public class atiqController : Controller
    {
        //
        // GET: /atiq/

        /*public ActionResult Index()
        {
            return View();
        }*/

        public string Index()
        {
            return "<html>"+
                "<title>"+
                "Resume of Md. Atiqur Rahman"+
                "</title>"+
                "<body><p align=\"center\"><a href=\"http://saos.co.in/Downloads/SA_Resume_latex.pdf\">Download original</a><br /><br />" +
                "<iframe src="+"http://docs.google.com/viewer?url=http%3A%2F%2Fsaos.co.in%2FDownloads%2FSA_Resume_latex.pdf&embedded=true"+
                " width=\"1024\" height=\"3900\" style=\"border: none;\"></iframe></p></body></html>";
        }
    }
}
