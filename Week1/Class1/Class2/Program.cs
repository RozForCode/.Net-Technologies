// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter sub total");

double subTotal = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Enter Discount Percentage:");

double discountPercent = Convert.ToDouble(Console.ReadLine()!);

double discountAmount = subTotal * (discountPercent / 100);
double total = subTotal - discountAmount;

Console.WriteLine($"Sub Total: {subTotal:C2}");
Console.WriteLine($"Discount Percent: {discountPercent}%");
Console.WriteLine($"Discount Amount: {discountAmount:C2}");
