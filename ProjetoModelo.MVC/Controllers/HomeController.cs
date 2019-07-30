using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModelo.MVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index ( ) {
            return View();
        }

        public ActionResult About ( ) {
            ViewBag.Message = "Página feita em MVC5 com ASP.NET";

            return View();
        }

        public ActionResult Contact ( ) {
            ViewBag.Message = "laneramos@gmail.com";

            return View();
        }
    }
}