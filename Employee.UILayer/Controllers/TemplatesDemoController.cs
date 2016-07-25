using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.UILayer.Controllers
{
    public class TemplatesDemoController : Controller
    {
        // GET: TemplatesDemo
        public ActionResult Index()
        {
            return View(new TemplateModel { Price=100,Date=DateTime.Now});
        }
    }

    public class TemplateModel
    {
        public decimal Price { get; set; }

        public DateTime Date { get; set; }
    }
}