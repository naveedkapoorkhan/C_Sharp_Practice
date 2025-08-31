//Learning objectives
//After you complete this module, you'll be able to:

//1.Perform mathematical operations on numeric values

//2.Observe implicit type conversion between strings and numeric values

//3.Temporarily convert one data type into another

//..............********************************......................//
//1.Perform mathematical operations on numeric values


//int x = 3 + 5;
//Console.WriteLine(x);
//string firstName = "Bob";
//int widgetsSold = 7;
//Console.WriteLine("{0}{1}{0}",firstName,widgetsSold,x);
//decimal firstName = 12.12222222223333333322m;
//float name = (float)firstName;
//Console.WriteLine(name);
//int value = 2;
//value=(int)Math.Pow(value, 2);
//Console.WriteLine(value);   // Output: 4

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * 5.0m / 9.0m;
Console.WriteLine($"THE TEMPRETURE IS:{celsius} celsius");   // Output: 34
Console.WriteLine(5 / 10);