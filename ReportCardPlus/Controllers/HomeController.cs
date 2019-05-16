using ReportCardPlus.DAL;
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
             SchoolContext db = new SchoolContext();
            return View(db.Students.ToList());
            }
        }
    }
