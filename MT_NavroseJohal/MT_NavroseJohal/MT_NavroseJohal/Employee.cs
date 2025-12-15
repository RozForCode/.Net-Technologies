using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NavroseJohal
{
    public enum EmployeeType
    {
        Hourly = 1,
        Commission = 2,
        Salaried = 3,
        SalaryPlusCommission = 4
    }
    internal abstract class Employee
    {
        public EmployeeType EmployeeType { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeId { get; set; }

        public Employee(string id, string name, EmployeeType type)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeeType = type;
        }



        public abstract decimal GrossEarnings { get; }



        
        public decimal Tax { get=> Math.Round(GrossEarnings * 0.20m, 2); }

        public decimal NetEarnings { get => Math.Round(GrossEarnings - Tax, 2); }

        
        /// Used chatGPT for formatting the string
        public override string ToString()
        {
            return string.Format(
                "|{0,-6} | {1,-15} | {2,-25} | {3,12:C} | {4,12:C} | {5,12:C}|",
                EmployeeId,
                EmployeeName,
                EmployeeType,
                GrossEarnings,
                Tax,
                NetEarnings
            );
        }
    }
}
