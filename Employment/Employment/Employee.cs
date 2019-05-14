using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace Employment
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal PensionFundTotal { get; set; }
        public decimal ProviderName { get; set; }

        public List<Employee> GetEmployeeList()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmploymentConnection"].ConnectionString);
            string Sqlstring = "Select * from employees_with_pensions";
            var employees = (List <Employee>)db.Query<Employee>(Sqlstring);
            return employees;
        }
    }

 
}
