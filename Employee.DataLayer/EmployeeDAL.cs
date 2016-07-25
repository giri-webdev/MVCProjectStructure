using Employee.DataLayer.Interfaces;
using Employee.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataLayer
{
   public class EmployeeDAL:IEmployee
    {
       private readonly string  
           _connectionString= @"Data Source=System0;Initial Catalog=Employee;Integrated Security=SSPI;";
              
       private readonly IEmployee _dataObject;

       //For Unit Test
       public EmployeeDAL(IEmployee emp)
       {
           _dataObject = emp;
       }

       public EmployeeDAL()
       {

       }

       public virtual bool Add(EmployeeModel employee)
       {
          //using(SqlConnection conn = new SqlConnection(_connectionString))
          //{
          //    conn.Open();
          //    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_EmployeeMaster VALUES(@FirstName,@LastName,@Age,@Salary)", conn);
          //    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
          //    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
          //    cmd.Parameters.AddWithValue("@Age", employee.Age);
          //    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
          //    cmd.ExecuteNonQuery();
          //}

          //return true;

           using(var context = new EmployeeEntities())
           {
               context.tbl_EmployeeMaster.Add(new tbl_EmployeeMaster { 
                   FirstName=employee.FirstName,
                   LastName=employee.LastName,
                   Age=employee.Age,
                   Salary=employee.Salary
               });
               context.SaveChanges();
           }

           return true;
       }

       public bool Edit(EmployeeModel employee)
       {
           throw new NotImplementedException();
       }

       public List<EmployeeModel> GetEmployeeList()
       {
           List<EmployeeModel> list = new List<EmployeeModel>();

           //using (SqlConnection conn = new SqlConnection(_connectionString))
           //{
           //    conn.Open();

           //    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_EmployeeMaster",conn);
           //    SqlDataReader  rdr = cmd.ExecuteReader();
           //    while(rdr.Read())
           //    {
           //        list.Add(new EmployeeModel {
           //            Id=rdr.GetInt32(0),
           //         FirstName = rdr.GetString(1),
           //         LastName = rdr.GetString(2),
           //         Age = rdr.GetInt32(3),
           //         Salary = rdr.GetDecimal(4)
           //        });
           //    }
           //}

           using(var db = new EmployeeEntities())
           {
              var empMasterList = db.tbl_EmployeeMaster.ToList();

               foreach(var emp in empMasterList)
               {
                   list.Add(new EmployeeModel
                   {
                       Id = emp.Id,
                       FirstName = emp.FirstName,
                       LastName = emp.LastName,
                       Age = emp.Age,
                       Salary = emp.Salary
                   });
               }
           }

           return list;
       }
    }
}
