using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            ComissionEmployee ce1 = new ComissionEmployee(1, "George", 50000, 0.25M);
            Console.WriteLine(string.Format("The monthly pay for Commission Employee 1 (ce1) is : {0:C}", ce1.CalculatePay()));

            SalaryEmployee s1 = new SalaryEmployee(2, "Mary", 50000);
            Console.WriteLine(string.Format("The monthly pay for Salary Employee 1 (s1) is : {0:C}", s1.CalculatePay()));

            HourlyEmployee h1 = new HourlyEmployee(3, "Spaz", 65);  // Rate = 65$/hr.
            Console.WriteLine(string.Format("The monthly pay for Hourly Contract Employee 1 (h1) is : {0:C}", h1.CalculatePay()));
        }
    }
}
