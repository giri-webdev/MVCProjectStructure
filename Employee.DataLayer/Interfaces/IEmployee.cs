using Employee.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataLayer.Interfaces
{
   public interface IEmployee
    {
       bool Add(EmployeeModel employee);

       bool Edit(EmployeeModel employee);

       List<EmployeeModel> GetEmployeeList();
    }
}
