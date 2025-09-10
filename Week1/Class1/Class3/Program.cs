// See https://aka.ms/new-console-template for more information

using Class3;

Account account = new Account();

try
{
    Console.WriteLine("Please choose option from the following");
    Console.WriteLine("1. Open account with some depost.");
    Console.WriteLine("2. Open account with zero value account.");
    Console.WriteLine("User Selection: ");

    int userInput = int.Parse(Console.ReadLine()!);

    decimal amount = 0.0M;
    if (userInput == 1)
    {
        Console.WriteLine("Please Enter an amount to deposist");
        amount = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine($"Amount: {amount}");
        account = new Account(amount);
        Console.WriteLine($"Account is Opened Successfully. Current Balance: {account.GetBalance():C}");
    }
    else if (userInput == 2)
    {

        account = new Account();
        Console.WriteLine($"Account is Opened Successfully. Current Balance: {account.GetBalance():C}");

    }
    Console.WriteLine("Please choose one of the following options: ");
    Console.WriteLine("1. Deposist Amount");
    Console.WriteLine("2. Withdraw Amount");
    Console.WriteLine("3. View Balance");
    Console.Write("User Selection : ");
    userInput = int.Parse(Console.ReadLine()!);
    switch (userInput)
    {
        case 1:
            Console.WriteLine("Please Enter an Amount");
            account.Deposit(decimal.Parse(Console.ReadLine()!));
            Console.WriteLine($"Amount Deposited Successfully. \n Current Balance: {account.GetBalance():C}");
            break;
        case 2:
            Console.WriteLine("Please Enter an Amount");
            account.Withdraw(decimal.Parse(Console.ReadLine()!));
            Console.WriteLine($"Amount Deposited Successfully. \n Current Balance: {account.GetBalance():C}");
            break;
        case 3:
            Console.WriteLine($"\n Current Balance: {account.GetBalance():C}");
            break;
        default:
            Console.WriteLine("Invalid value"); break;
        }
    }
catch (ArgumentException ex) {
    Console.Write($"\nException: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.Write($"\nException: {ex.Message}");
}
catch (Exception ex)
{
    Console.Write($"\nException: {ex.Message}");
}