// See https://aka.ms/new-console-template for more information
/*
 
Normally, value types (like int) cannot store null.
But you can make them nullable with ?.

int? optionalNumber = null;

*/

// we also have var, dynamic and const 

using O_reilly_Learning___1;

//var x = 0;
//dynamic z = 0;
//z = "hel;p";
//const double PI  = Math.PI;

// Conversions 
//int a = 10;

//double b = a; // Implicit

double x1 = 9.8;
int y = (int)x1; // Explicit
Console.WriteLine(y);


string line = "123";
int number = int.Parse(line); // throws error if invalid

Console.WriteLine(number);
bool success = int.TryParse(line, out int safeNum); // safer way to doing string to int conversion

// if fails then value of safeNum will be 0
if(success){
Console.WriteLine(safeNum);
}

CelciusToFarenheit.run();