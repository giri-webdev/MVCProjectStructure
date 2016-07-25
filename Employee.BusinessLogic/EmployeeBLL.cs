using Employee.BusinessLogic.Interfaces;
using Employee.BusinessLogic.ViewModels;
using Employee.DataLayer;
using Employee.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BusinessLogic
{
   public class EmployeeBLL:IEmployeeLogic
    {
       EmployeeDAL emp;

       public EmployeeBLL()
       {
           emp = new EmployeeDAL();
       }

       //For Unit Test
       public EmployeeBLL(EmployeeDAL dalObj)
       {
           emp = dalObj;
       }

       public bool Add(EmployeeViewModel empObject)
       {
           EmployeeModel empModel = new EmployeeModel
           {
               FirstName = empObject.FirstName,
               LastName = empObject.LastName,
               Age = empObject.Age,
               Salary = empObject.Salary
           };

           return emp.Add(empModel);
       }

       public List<EmployeeModel> GetEmployeeList()
       {
           return emp.GetEmployeeList();
       }
    }
}
