//before any conversion keep these two points in the mind
//   I. Is it possible, depending on the value, that attempting to change the value's data type would throw an exception at run time?
//   II. Is it possible, depending on the value, that attempting to change the value's data type would result in a loss of information?

//1.Use the casting operator to cast a value into a different data type.
//Write code that attempts to add an int and a string and save the result in an int


int first = 5;
string second = "2";
string Result = first + second;
Console.WriteLine(Result);
//when you convert small data to large data never loss and compiler did it implicitly but if you need to convert large data into small data you will did explicitly will loss 
int x = 5;
double y = x;
Console.WriteLine($"y is double no data loss::{y}");
double z = 2.6745678;
int a = (int)z;
Console.WriteLine($"data will loos because large into small::{a} ");

//To perform data conversion, you can use one of several techniques:

//Use a helper method on the data type
//Use a helper method on the variable
//Use the Convert class' methods

//Use ToString() to convert a number to a string
int firstNumber = 5;
int secondNumber = 10;
string final = firstNumber.ToString() + secondNumber.ToString();
Console.WriteLine($"final store string after tostring() ::{final}");
Console.WriteLine($"without using third variable::{firstNumber}{secondNumber}");

//Convert a string to an int using the Parse() helper method
//it will throw exception 
//string name = "Naveed";
//int name1 = int.Parse(name);
//Console.WriteLine(name1);

//string name3 = "123";
//int name2 = int.Parse(name3);
//Console.WriteLine(name2);

//use parse hen you sure the valid number in string otherwise it will throw exception and how to avoid that exception use tryParse

string name3 = "12345";
int result = 0;
bool name2 = int.TryParse(name3,out  result); 
Console.WriteLine(name2);
if (name2)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("wrong input ");
}


//2.Use conversion methods to convert a value into a different data type.
//Convert a string to a int using the Convert class
string Name = "12322";
int NName=Convert.ToInt32(Name);
Console.WriteLine(NName);

//So, when should you use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.

double d = 26.6789d;
int n= Convert.ToInt32(d);

Console.WriteLine(n);//27 because rounding off and no data loss if use convert


//3.Guard against the loss of data when performing a cast or conversion operation.

decimal data = 26.6789545767m;
int num = Convert.ToInt32(d);

Console.WriteLine(num);//27 because rounding off and no data loss if use convert

//When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1, meaning the value after the decimal is ignored completely. You could change the literal float to 1.999m and the result of casting would be the same.

//When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If you changed the literal value to 1.499m, it would be rounded down to 1.

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

//Recap
//Prevent a runtime error while performing a data conversion
//Perform an explicit cast to tell the compiler you understand the risk of losing data
//Rely on the compiler to perform an implicit cast when performing an expanding conversion
//Use the () cast operator and the data type to perform a cast (for example, (int)myDecimal)
//Use the Convert class when you want to perform a narrowing conversion, but want to perform rounding, not a truncation of information


//4.Use the TryParse() method to safely convert a string into a numeric data type.

string numbers = "123";
int result1 = 0;
bool names2 = int.TryParse(numbers, out result1);
Console.WriteLine(names2);
int result2 = result1 + 50;
if (names2)
{
    Console.WriteLine(result2);
    string numbers12 = result2.ToString();
    Console.WriteLine($"numbers12::{numbers12}");
    numbers = numbers12;

    Console.WriteLine(numbers);
}
else
{
    Console.WriteLine("wrong input ");
}

//Use TryParse() when converting a string into a numeric data type.
//TryParse() returns true if the conversion is successful, false if it's unsuccessful.
//Out parameters provide a secondary means of a method returning a value. In this case, the out parameter returns the converted value.
//Use the keyword out when passing in an argument to a method that has defined an out parameter.