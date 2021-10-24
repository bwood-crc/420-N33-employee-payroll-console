using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class ComissionEmployee : SalaryEmployee
    {
        public ComissionEmployee(int id, string name, decimal yearlySalary, decimal commissionRate) : base(id, name, yearlySalary)
        {
            this.ComissionRate = commissionRate;
        }

        // A comissioned employee has a salary and also a comission rate.  Each employee can have a different comission depending on their contract agreement.
        public decimal ComissionRate { get; set; }

        public override decimal CalculatePay()
        {
            return base.CalculatePay() + (base.CalculatePay() * this.ComissionRate);
        }
    }
}
