using Employee.BusinessLogic.ViewModels;
using Employee.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BusinessLogic.Interfaces
{
   public interface IEmployeeLogic
    {
        bool Add(EmployeeViewModel empObject);

        List<EmployeeModel> GetEmployeeList();
    }
}
