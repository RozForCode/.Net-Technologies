// See https://aka.ms/new-console-template for more information
using LINQEmployees;

// Create a list of employees
List<Employee> employees = new List<Employee>
{
    new Employee("John", "Smith", 5000),
    new Employee("Jane", "Doe", 6000.99M),
    new Employee("Sam", "Brown", 5500.75M),
    new Employee("Sara", "White", 6000),
    new Employee("Mike", "Smith", 4500),
    new Employee("Emily", "Clark", 8000),
    new Employee("David", "Wilson", 7500.49M),
    new Employee("Anna", "Wilson", 7200.65M)
};

// Defining LINQ Queries

// LINQ Query to select employees with salary greater than 4000 and less than 6000
var between4K6K = from emp in employees
                 where emp.MonthlySalary >= 4000 && emp.MonthlySalary <= 6000
                 select emp;

// LINQ Query to sort employees by LastName and then by FirstName
var nameSorted = from emp in employees
                 orderby emp.LastName, emp.FirstName
                 select emp;

// LINQ Query to count employees
var counts = from emp in employees
             select emp;

// LINQ Query To Get Unique Last Names
var uniqueLastNames = from emp in employees
                        select emp.LastName;

// LINQ Query to define an anonymous type with FullName and MonthlySalary
var fullNames = from emp in employees
                select new { FullName = $"{emp.FirstName} {emp.LastName}", MonthlySalary = "$" + emp.MonthlySalary };

// Execute LINQ queries and print the results
Console.WriteLine($"Employees with salary between {4000:C} and {6000:C}:\n");
foreach (var emp in between4K6K) Console.WriteLine(emp);

// Printing sorted names
Console.WriteLine($"\nList of Employees Name in Sorted Order : \n");
foreach (var emp in nameSorted) Console.WriteLine(emp);

// Print only First Record from sorted names
Console.WriteLine($"\nFirst Employee from Sorted List : \n");
if(nameSorted.Any()) Console.WriteLine(nameSorted.First());
else Console.WriteLine("No employees found.");

//Print count of employees using Count() Method
Console.WriteLine($"\nTotal Number of Employees : {counts.Count()}");

// Print count of employees using Count Property
Console.WriteLine($"\nTotal Number of Employees using Count Property : {employees.Count}");

// Print Unique Last Names
Console.WriteLine($"\nUnique Last Names from Employee List : \n");
foreach (var lastName in uniqueLastNames.Distinct()) Console.WriteLine(lastName);

// Print Full Names
Console.WriteLine($"\nFull Names of Employees : \n");
foreach (var fullName in fullNames) Console.WriteLine(fullName.ToString());

Console.WriteLine("\nPress any key to terminate...");
Console.ReadKey();