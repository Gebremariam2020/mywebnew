using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mywebnew.Controllers
{
    public class HomeController : Controller
    {
     
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "this is my first project ";
            ViewBag.Message = "this is esmaeal  and gebre ";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "you can  contact  by  link below for more  desciption ";

            return View();
        }
    }
}