using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    ListEmployees();
                }
                else if (outputMessage == "Adding 5% of Salary to pension fund")
                {
                    AddFivePercentToPension();
                }
            }
            else
            {
                Console.WriteLine("This is not a valid input. Please select either 1 or 2");
            }

            Console.ReadLine();
        }

        private void ListEmployees()
        {
            var employees = new Employee();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            var listemployees = employees.GetEmployeeList();
            timer.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss\\:fff}", timer.Elapsed);

            //foreach (var employee in listemployees)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Name: " + listemployees[i].Name);
                Console.WriteLine("Salary: £" + listemployees[i].Salary);
                Console.WriteLine("Pension Fund Total: £" + listemployees[i].Pension_Fund_Total);
                Console.WriteLine("Pension Provider: " + listemployees[i].Provider_Name);
                Console.WriteLine();
            }
        }

        private void AddFivePercentToPension()
        {
            var employees = new Employee();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            employees.AddToPension();
            timer.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss\\:fff}", timer.Elapsed);
            ListEmployees();
        }
    }
}
