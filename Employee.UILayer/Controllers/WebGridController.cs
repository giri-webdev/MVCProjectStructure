using Employee.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.UILayer.Controllers
{
    public class WebGridController : Controller
    {

        EmployeeBLL businessLogic = new EmployeeBLL();

        public ActionResult Home()
        {
            return View("Index",businessLogic.GetEmployeeList());
        }

        public ActionResult SimpleGrid()
        {
            return View(businessLogic.GetEmployeeList());
        }

        [HttpPost]
        public ActionResult AddInput(string input)
        {
            return Json(new { result = "Input added successfully." });
        }

        [HttpGet]
        public ActionResult EmployeeInfo()
        {
            return PartialView();
        }
    }

   
}