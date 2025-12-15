// See https://aka.ms/new-console-template for more information
using A2NavroseJohal;

// Adding Sample Data
List<Employee> employees = new List<Employee>
{
    // Salaried Employees
    new SalariedEmployee("E1001", "Alice", 5000m),
    new SalariedEmployee("E1002", "David", 7000m),

    // Hourly Employees
    new HourlyEmployee("E1003", "Bob", 20m, 160),
    new HourlyEmployee("E1004", "Eva", 25m, 120),

    // Commission Employees
    new CommissionEmployee("E1005", "Charlie", 20000m, 0.10m),
    new CommissionEmployee("E1006", "Frank", 30000m, 0.15m),

    // Salary + Commission Employees
    new SalaryPlusCommissionEmployee("E1007", "Grace", 4000m, 15000m, 0.05m),
    new SalaryPlusCommissionEmployee("E1008", "Hank", 6000m, 25000m, 0.08m)
};
// testing
Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    
}
Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
int id = 1009;

// showing menu
int choice = 0;
while (choice != 6)
{

    Console.WriteLine("=== Employee Wage Calculator ===");
    Console.WriteLine("1 - Add Employee");
    Console.WriteLine("2 - Edit Employee");
    Console.WriteLine("3 - Delete Employee");
    Console.WriteLine("4 - View Employees");
    Console.WriteLine("5 - Search Employee");
    Console.WriteLine("6 - Exit");
    Console.WriteLine("================================");


    Console.WriteLine("Select an option: ");
    string input = Console.ReadLine()!;
    int.TryParse(input, out choice);

    Console.WriteLine();
    //add employee
    if (choice == 1)
    {
        Console.WriteLine("Select the type of Employee you want to add:");
        Console.WriteLine("1 - HourlyEmployee");
        Console.WriteLine("2 - CommissionEmployee");
        Console.WriteLine("3 - SalariedEmployee");
        Console.WriteLine("4 - SalaryPlusCommissionEmployee");

        int choice2;
        int.TryParse(Console.ReadLine(), out choice2);

        EmployeeType employeeType;
        if (choice2 == (int)EmployeeType.Hourly) employeeType = EmployeeType.Hourly;
        if (choice2 == (int)EmployeeType.Salaried) employeeType = EmployeeType.Salaried;
        if (choice2 == (int)EmployeeType.Commission) employeeType = EmployeeType.Commission;
        if (choice2 == (int)EmployeeType.SalaryPlusCommission) employeeType = EmployeeType.SalaryPlusCommission;


        // unique id generation code
        id += 1;
        String uniqueId = "E" + id.ToString();
        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;

        Employee newEmployee = null;

        if (choice2 == 1)
        {

            Console.Write("Enter Hourly Rate: ");
            decimal hourlyRate = decimal.Parse(Console.ReadLine()!);

            Console.Write("Enter Hours Worked: ");
            int hoursWorked = int.Parse(Console.ReadLine()!);

            newEmployee = new HourlyEmployee(uniqueId, name, hourlyRate, hoursWorked);
        }
        else if (choice2 == 2)
        {

            Console.Write("Enter Gross Sales: ");
            decimal grossSales = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Commission Rate: ");
            decimal commissionRate = decimal.Parse(Console.ReadLine());

            newEmployee = new CommissionEmployee(uniqueId, name, grossSales, commissionRate);
        }
        else if (choice2 == 3)
        {

            Console.Write("Enter Weekly Salary: ");
            decimal weeklySalary = decimal.Parse(Console.ReadLine());

            newEmployee = new SalariedEmployee(uniqueId, name, weeklySalary);
        }
        else if (choice2 == 4)
        {

            Console.Write("Enter Base Salary: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Gross Sales: ");
            decimal grossSales = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Commission Rate: ");
            decimal commissionRate = decimal.Parse(Console.ReadLine());

            newEmployee = new SalaryPlusCommissionEmployee(uniqueId, name, baseSalary, grossSales, commissionRate);
        }

        if (newEmployee != null)
        {
            employees.Add(newEmployee);
            Console.WriteLine("\n Employee added successfully!\n");

            // Print only employees of that type
            Console.WriteLine("Employees in this category:");

            Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
            foreach (var emp in employees.Where(e => e.GetType() == newEmployee.GetType()))
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
        }
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeType == employees[employees.Count - 1].EmployeeType)
            {
                Console.WriteLine(employee);
            }
        }
        Console.WriteLine("\n\n");

    }
    else if (choice == 2)
    {
        Console.WriteLine("Select the type of Employee you want to edit:");
        Console.WriteLine("1 - HourlyEmployee");
        Console.WriteLine("2 - CommissionEmployee");
        Console.WriteLine("3 - SalariedEmployee");
        Console.WriteLine("4 - SalaryPlusCommissionEmployee");

        int choice2;
        int.TryParse(Console.ReadLine(), out choice2);

        EmployeeType employeeType = 0;
        if (choice2 == (int)EmployeeType.Hourly) employeeType = EmployeeType.Hourly;
        if (choice2 == (int)EmployeeType.Salaried) employeeType = EmployeeType.Salaried;
        if (choice2 == (int)EmployeeType.Commission) employeeType = EmployeeType.Commission;
        if (choice2 == (int)EmployeeType.SalaryPlusCommission) employeeType = EmployeeType.SalaryPlusCommission;


        Console.WriteLine("You can edit the following employees:");

        Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeType == employeeType)
            {
                Console.WriteLine(employee);
            }
        }

        Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
        Console.WriteLine("\n\n");
        Console.Write("Enter Employee ID to edit: ");
        string empId = Console.ReadLine();

        Employee empToEdit = null;
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeId == empId)
            {
                empToEdit = employee;
            }
        }
        // now we have employee object
        if (empToEdit == null)
        {
            Console.WriteLine("Employee not found.");
        }
        else
        {
            Console.WriteLine("Editing employee: " + empToEdit.EmployeeName);

            // Update based on type
            if (empToEdit is HourlyEmployee he)
            {
                Console.Write("Enter new Name: ");
                he.EmployeeName = Console.ReadLine();

                Console.Write("Enter new Hourly Rate: ");
                he.HourlyWage = decimal.Parse(Console.ReadLine());

                Console.Write("Enter new Hours Worked: ");
                he.HoursWorked = int.Parse(Console.ReadLine());
            }
            else if (empToEdit is CommissionEmployee ce)
            {
                Console.Write("Enter new Name: ");
                ce.EmployeeName = Console.ReadLine();

                Console.Write("Enter new Gross Sales: ");
                ce.GrossSales = decimal.Parse(Console.ReadLine());

                Console.Write("Enter new Commission Rate: ");
                ce.CommissionRate = decimal.Parse(Console.ReadLine());
            }
            else if (empToEdit is SalariedEmployee se)
            {
                Console.Write("Enter new Name: ");
                se.EmployeeName = Console.ReadLine();

                Console.Write("Enter new Weekly Salary: ");
                se.WeeklySalary = decimal.Parse(Console.ReadLine());
            }
            else if (empToEdit is SalaryPlusCommissionEmployee spc)
            {
                Console.Write("Enter new Name: ");
                spc.EmployeeName = Console.ReadLine();

                Console.Write("Enter new Base Salary: ");
                spc.WeeklySalary = decimal.Parse(Console.ReadLine());

                Console.Write("Enter new Gross Sales: ");
                spc.GrossSales = decimal.Parse(Console.ReadLine());

                Console.Write("Enter new Commission Rate: ");
                spc.CommissionRate = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n✅ Employee updated successfully!\n");

            // Show updated employees of this category
            Console.WriteLine("Employees in this category:");

            Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
            foreach (var emp in employees)
            {
                if (emp.EmployeeType == employeeType)
                {
                    Console.WriteLine(emp);
                }
            
            Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
        }



    }




    //delete employee


    else if (choice == 3)
    {
        Console.WriteLine("Select the type of Employee you want to delete:");
        Console.WriteLine("1 - HourlyEmployee");
        Console.WriteLine("2 - CommissionEmployee");
        Console.WriteLine("3 - SalariedEmployee");
        Console.WriteLine("4 - SalaryPlusCommissionEmployee");

        int choice2;
        int.TryParse(Console.ReadLine(), out choice2);

        EmployeeType employeeType = 0;
        if (choice2 == (int)EmployeeType.Hourly) employeeType = EmployeeType.Hourly;
        if (choice2 == (int)EmployeeType.Salaried) employeeType = EmployeeType.Salaried;
        if (choice2 == (int)EmployeeType.Commission) employeeType = EmployeeType.Commission;
        if (choice2 == (int)EmployeeType.SalaryPlusCommission) employeeType = EmployeeType.SalaryPlusCommission;


        Console.WriteLine("You can delete the following employees:");
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeType == employeeType)
            {
                Console.WriteLine(employee);
            }
        }
        Console.WriteLine("\n\n");
        Console.WriteLine("Editing Employee");
        Console.Write("Enter Employee ID to delete: ");
        string empId = Console.ReadLine();

        Employee empToDelete = null;
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeId == empId)
            {
                empToDelete = employee;
            }
        }
        // now we have employee object
        if (empToDelete == null)
        {
            Console.WriteLine("Employee not found.");
        }
        else
        {
            employees.Remove(empToDelete);
        }
        Console.WriteLine("Remaining employees in this category:");

        Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeType == employeeType)
            {
                Console.WriteLine(employee);
            }
        }

        Console.WriteLine("|-------------------------------------------------------------------------------------------------|");



    }


    // show all employees
    else if (choice == 4)
    {

        Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine("|-------------------------------------------------------------------------------------------------|");
    }



    /// search
    else if (choice == 5)
    {
        Console.Write("Enter name of employee you want the details of:");
        String name = Console.ReadLine();
        Employee emp = null;
        bool found = false;
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeName.ToLower().Contains(name.ToLower()))
            {
                found = true;
                Console.WriteLine("\n", employee, "\n\n");
            }

        }
        if (!found) Console.WriteLine($"Employee of name ${name} doesn't exist");

    }

}



