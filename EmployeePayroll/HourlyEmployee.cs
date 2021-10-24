using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee(int id, string name, decimal hourlyRate) : base(id, name)
        {
            this.HourlyRate = hourlyRate;
        }

        public decimal HourlyRate { get; set; }

        public override decimal CalculatePay()
        {
            // Assume 160 hours per month worked, 8 hours per day.
            return this.HourlyRate * 160;
        }
    }
}
