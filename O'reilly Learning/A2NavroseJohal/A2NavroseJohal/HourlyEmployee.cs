using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NavroseJohal
{
    internal class HourlyEmployee:Employee
    {
        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }

        public HourlyEmployee(string id, string name, decimal wage, decimal hours)
            : base(id, name, EmployeeType.Hourly)
        {
            HourlyWage = wage;
            HoursWorked = hours;
        }

        public override decimal GrossEarnings
        {
            get
            {
                if (HoursWorked <= 40) return Math.Round(HourlyWage * HoursWorked, 2);
                var overtime = HoursWorked - 40;
                return Math.Round(40 * HourlyWage + overtime * HourlyWage * 1.5m, 2);
            }
        }
    }
}
