using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportCardPlus.Controllers
    {
    public class HomeController : Controller
        {
        public ActionResult Index()
            {
            ViewBag.Title = "Homes ";

            return View();
            }
        }
    }
