// See https://aka.ms/new-console-template for more information

// Create a list of colors
List<string> colors = new List<string>();

// Add some colors to the list
colors.Add("aQua");
colors.Add("RusT");
colors.Add("yElLow");
colors.Add("rED");

// Define LINQ Query to select colors that start with 'r' or 'R'
/*var startWithR = from color in colors
                 where color.StartsWith("R", StringComparison.OrdinalIgnoreCase)
                 orderby color
                 select color;*/

// Define LINQ Query to select colors that start with 'r' or 'R'
var startWithR = from color in colors
                 let upperColor = color.ToUpper()
                 where upperColor.StartsWith("R")
                 orderby upperColor
                 select upperColor;

// Execute the query and print the results
Console.WriteLine("The Selected Colors from LINQ Query Are : \n");
foreach(var color in startWithR) Console.WriteLine(color);

// Add more colors to the list
colors.Add("rUBy");
colors.Add("sIlVeR");
colors.Add("gReEn");
colors.Add("SafFRon");

// Execute the query and print the results
Console.WriteLine("\nThe Selected Colors from LINQ Query After Adding More Colors Are : \n");
foreach (var color in startWithR) Console.WriteLine(color);

Console.WriteLine("\nPress Enter to terminate...");
Console.ReadLine();