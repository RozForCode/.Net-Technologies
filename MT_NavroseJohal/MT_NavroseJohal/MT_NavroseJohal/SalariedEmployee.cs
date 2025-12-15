using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NavroseJohal
{
    internal class SalariedEmployee:Employee
    {
        public decimal WeeklySalary { get; set; }

        public SalariedEmployee(string id, string name, decimal salary)
            : base(id, name, EmployeeType.Salaried)
        {
            WeeklySalary = salary;
        }

        public override decimal GrossEarnings => Math.Round(WeeklySalary, 2);
    }
}
