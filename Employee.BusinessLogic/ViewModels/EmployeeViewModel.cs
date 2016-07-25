using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BusinessLogic.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
}
