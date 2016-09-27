using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HorrocksPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "How Robert helps organizations like yours.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get a booster pack and two extra lives!!!";

            return View();
        }
    }
}