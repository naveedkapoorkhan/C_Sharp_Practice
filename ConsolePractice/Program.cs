//Format alphanumeric data for presentation in C#
//Use character escape sequences to add tabs, new lines, and Unicode characters to our strings.

//Create verbatim string literals, and escape common characters like backslash ( \ ) and double-quotes ( "" ).

//Merge templates with variables using composite formatting and string interpolation.

//Include various format specifiers for percentages, currency, and numbers.

//Composite Formatting? uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a
//value that is also passed in based on their position.

//This example of composite formatting uses a built-in method Format() on the string data type keyword.
string first = "Hello";
string second = "World";
//The literal string "{0} {1}!" forms a template, parts of which are replaced at run time.
//The token {0} is replaced by the first argument after the string template, in other words, the value of the variable first.
//The token {1} is replaced by the second argument after the string template, in other words, the value of the variable second.
string result=string.Format("First Name{1}\nLast Name:{0}", first,second);
Console.WriteLine(result);


string First = "Hello";
string Second = "World";
Console.WriteLine(string.Format("{0} {1} {0}", first, second));
Console.WriteLine("{0} {0} {1}!", first, second);//string.format is overload here by writeline();


//String interpolation is a technique that simplifies composite formatting.

//Instead of using a numbered token and including the literal value
//or variable name in a list of arguments to String.Format() or Console.WriteLine(),
//you can just use the variable name inside of the curly braces.

//In order for a string to be interpolated, you must prefix it with the $ directive. 

Console.WriteLine($""); //its become interpolation Now
string first1 = "Hello";
string second1 = "World";
Console.WriteLine($"{first1} {second1}!");
Console.WriteLine($"{second1} {first1}!");
Console.WriteLine($"{first1}\n         {first1} \n{first1}!");


//Formatting currency Composite formatting and string interpolation can be used to format values for display given a specific language and culture.
//In the following example,the :C currency format specifier is used to present the price and discount variables as currency

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
//output::Price: $123.45 (Save $50.00)

//What if you execute the previous code on a computer in France that has its Windows Display Language set to French?
//  In that case you would see the following output.  Price: 123,45 € (Save 50,00 €)

//The reason for the previous "€" output is that the string currency formatting feature is dependent on the local computer setting for culture.
//In this context, the term "culture" refers to the country/region and language of the end user.
//The culture code is a five character string that computers use to identify the location and language of the end user.
//The culture code ensures certain information like dates and currency can be presented properly.


decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N9} units");
//If you're viewing this from the en-US culture, you observe the following output.
// output  :Measurement: 123,456.7891 units four numbers after decimal because N4 en-US culture is used



decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");//Tax rate: 36.79%
Console.WriteLine($"Tax rate: {tax:P3}");//Tax rate: 36.785%
//If you're viewing this from the en-US culture, you observe the following output.
//Tax rate: 36.79%


//Combining formatting approaches
decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price1 - salePrice), price1+price1);

Console.WriteLine(yourDiscount);

//All of the above in one code

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");