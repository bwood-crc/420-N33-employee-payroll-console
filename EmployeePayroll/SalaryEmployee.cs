using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class SalaryEmployee : Employee
    {
        public SalaryEmployee(int id, string name, decimal yearlySalary) : base(id, name)
        {
            this.YearlySalary = yearlySalary;
        }

        // A salaried employee has a yearly salary.
        public decimal YearlySalary { get; set; }

        public override decimal CalculatePay()
        {
            return this.YearlySalary / 12;
        }
    }
}
