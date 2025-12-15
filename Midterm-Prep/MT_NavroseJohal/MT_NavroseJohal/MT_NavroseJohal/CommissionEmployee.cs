using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NavroseJohal
{
    internal class CommissionEmployee: Employee
    {
        public decimal GrossSales { get; set; }
        public decimal CommissionRate { get; set; } // 0.10 for 10%

        public CommissionEmployee(string id, string name, decimal sales, decimal rate)
            : base(id, name, EmployeeType.Commission)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }

        public override decimal GrossEarnings => Math.Round(GrossSales * CommissionRate, 2);
    }
}
