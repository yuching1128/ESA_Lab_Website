using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "實驗室簡介";

            return View();
        }

        public ActionResult Professor()
        {
            ViewBag.Message = "指導教授";

            return View();
        }

        public ActionResult Member()
        {
            ViewBag.Message = "實驗室成員";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "聯絡我";

            return View();
        }
    }
}

