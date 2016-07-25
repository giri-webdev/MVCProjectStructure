using Employee.BusinessLogic;
using Employee.BusinessLogic.Interfaces;
using Employee.BusinessLogic.ViewModels;
using Employee.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.UILayer.Controllers
{
    public class HomeController : Controller
    {
       public IEmployeeLogic businessLogic;

        public HomeController()
        {

        }

        //For UNIT TEST
        public HomeController(EmployeeDAL empObj)
        {
            businessLogic = new EmployeeBLL(empObj);
        }

        //For Dependency Injection
        public HomeController(IEmployeeLogic _logic)
        {
            businessLogic = _logic;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add(int a, int b)
        {
            int c = a + b;

            return View(c);
        }

        [HttpGet]
        public ActionResult Mul(int a,int b)
        {
            double c = a * b;
            return View(c);
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
               bool result = businessLogic.Add(viewModel);

                ViewBag.Message = "Employee added successfully.";

                return View("~/Views/Home/Index.cshtml",viewModel);
            }

            return View("~/Views/Home/Index.cshtml",viewModel);
        }

    }
}