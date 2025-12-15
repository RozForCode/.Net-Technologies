using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NavroseJohal
{
    internal class SalaryPlusCommissionEmployee:CommissionEmployee
    {
        public decimal WeeklySalary { get; set; }

        public SalaryPlusCommissionEmployee(string id, string name, decimal salary, decimal sales, decimal rate)
            : base(id, name, sales, rate)
        {
            WeeklySalary = salary;
            base.EmployeeType = EmployeeType.SalaryPlusCommission;
            base.EmployeeName = name;
            base.EmployeeId = id; // using protected/private from base; this compiles because base sets via constructor
        }

        public override decimal GrossEarnings => Math.Round(WeeklySalary + (GrossSales * CommissionRate), 2);
    }
}
