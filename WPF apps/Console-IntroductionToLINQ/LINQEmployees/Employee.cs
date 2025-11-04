using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEmployees
{
    public class Employee
    {
        //Auto-implemented properties for Employee class
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? MonthlySalary { get; set; }

        // Constructor to initialize Employee object
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        // Override ToString() method to display Employee details
        public override string ToString() => $"{FirstName, -10} {LastName, -10} {MonthlySalary:C}";
    }
}
