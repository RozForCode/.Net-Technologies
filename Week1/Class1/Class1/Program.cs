// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter circle radius");
double r = double.Parse(Console.ReadLine()!);

Console.WriteLine( "area of circle " + (Math.PI * r*r)); // or Math.Pow(value, power)
Console.WriteLine("circumference of circle " + (Math.PI * r * 2));
Console.WriteLine("Diameter of circle " + (2 * r));

// string interpolation - $"string {variable}"
// concatenation makes program vulnerable
// ( $"string {0}", area )
