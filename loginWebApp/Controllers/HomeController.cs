using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
         [Authorize(Users = "Mustak,Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Users = "Admin")]
        public ActionResult AdminPanal()
        {
            return View();
        }
        



        public ActionResult Men()
        {
            return View();
        }
        public ActionResult Women()
        {
            return View();
        }
        public ActionResult Kids()
        {
            return View();
        }

        public ActionResult Product_details()
        {
            return View();
        }
    }
}