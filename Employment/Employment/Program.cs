using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().RunEmploymentApp();
        }

        private void RunEmploymentApp()
        {
            Console.WriteLine("Welcome to the Employment Database");
            Console.WriteLine("Please select from the following options by keying the relevant number and pressing enter:");
            Console.WriteLine();
            Console.WriteLine("1: List of employees with their job role, salary and pension fund balance");
            Console.WriteLine("2: Add 5% of employee salary to the pension fund");
            Console.WriteLine();
            string input = Console.ReadLine();

            //check validity of input
            if (int.TryParse(input, out int value))
            {
                var process = new ValidateInput();
                var outputMessage = process.ValidationMessage(value);
                Console.WriteLine(outputMessage);
                //Console.ReadLine();

                if (outputMessage == "List of Employees")
                {
                    var employees = new Employee();
                    var listemployees = employees.GetEmployeeList();

                    foreach (var employee in listemployees)
                    {
                        Console.WriteLine("Name: " + employee.Name);
                        Console.WriteLine("Salary: £" + employee.Salary);
                        Console.WriteLine("Pension Fund Total: £" + employee.Pension_Fund_Total);
                        Console.WriteLine("Pension Provider: " + employee.Provider_Name);
                        Console.WriteLine();
                    }

                }
                else if (outputMessage == "Adding 5% of Salary to pension fund")
                {
                }
            }
            else
            {
                Console.WriteLine("This is not a valid input. Please select either 1 or 2");
                
            }

            Console.ReadLine();
        }
    }
}
