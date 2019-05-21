using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Dapper;


namespace Employment
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Pension_Fund_Total { get; set; }
        public string Provider_Name { get; set; }

        public IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmploymentConnection"].ConnectionString);
        
        public List<Employee> GetEmployeeList()
        {
            string Sqlstring = "Select * from employees_with_pensions";
            var employees = (List<Employee>)db.Query<Employee>(Sqlstring);
            return employees;
        }

        public void AddToPension()
        {
            db.Execute(@"exec add_to_employee_pension",commandTimeout:500);

        }
    }


}
