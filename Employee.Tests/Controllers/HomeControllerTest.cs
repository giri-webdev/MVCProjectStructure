using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee.UILayer;
using Employee.UILayer.Controllers;
using Employee.BusinessLogic.ViewModels;
using Employee.DataLayer;
using Moq;
using Employee.DataLayer.Models;

namespace Employee.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController controller;

        public HomeControllerTest()
        {
            controller = new HomeController();
        }

        [TestMethod]
        public void Index()
        {  
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddTest()
        {
            // Act
            ViewResult result = controller.Add(2,2) as ViewResult;

            // Assert
            Assert.AreEqual(result.Model,4);
        }


        [TestMethod]
        public void MulTest()
        {
            // Act
            ViewResult result = controller.Mul(25, 25) as ViewResult;

            // Assert
            bool output = Convert.ToDouble(result.Model) == 625;
            Assert.IsTrue(output);
            
        }

        [TestMethod]
        public void AddEmployeeTest()
        {
            EmployeeViewModel viewModel = new EmployeeViewModel
            {
                FirstName = "Giri",
                LastName = "Prasad",
                Age = 20,
                Id = 1,
                Salary = 10000
            };

            //Mock Type
            Mock<EmployeeDAL> dalObj = new Mock<EmployeeDAL>();

            //Mock Type Method
            dalObj.Setup(x => x.Add(It.IsAny<EmployeeModel>())).Returns(true);

            controller = new HomeController(dalObj.Object);

            ViewResult result = controller.AddEmployee(viewModel) as ViewResult;

           Assert.IsNotNull(result);
        }

        
    }
}
