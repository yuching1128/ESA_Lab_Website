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
        public ActionResult Publication()
        {
            ViewBag.Message = "著作";

            return View();
        }
        public ActionResult Research()
        {
            ViewBag.Message = "研究計畫";

            return View();
        }
        public ActionResult Patent()
        {
            ViewBag.Message = "專利";

            return View();
        }
        public ActionResult Honors()
        {
            ViewBag.Message = "獲獎殊榮";

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
        public ActionResult English()
        {
            ViewBag.Message = "英文版本";

            return View();
        }
    }
}

