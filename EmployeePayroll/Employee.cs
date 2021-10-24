using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    abstract class Employee : IPayrollCalculate
    {
        // Constructor
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public PayMethodEnum PayMethod { get; set; }
        public abstract decimal CalculatePay();
        
        protected PayMethodEnum DeterminePayMethod(decimal amount)
        {
            if (amount > Constants.MAX_CASH)
            {
                Console.WriteLine("Pay method determined to be ONLINE.");
                return PayMethodEnum.ONLINE;
            }

            Console.WriteLine("Pay method determined to be CASH.");
            return PayMethodEnum.CASH;
        }
    }
}
