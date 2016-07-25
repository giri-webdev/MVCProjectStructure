using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.UILayer.Controllers
{
    public class HtmlHelpersController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ModelBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModelBinding(HtmlHelperModel obj)
        {
            return View();
        }

        [HttpGet]
        public ActionResult HelperMethods()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(HtmlHelperModel obj)
        {
            return RedirectToAction("ModelBinding");
        }
    }

    public class HtmlHelperModel
    {
        public string Name { get; set; }

        public string Type { get; set; }
    }
}