using System.Data;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//Create a looping structure that can be used to iterate through each string value in the array values.
decimal result = 0m;
decimal sum = 0m;
string message="";


//Complete the required code,
//placing it within the array looping structure code block.
for (int i = 0; i < values.Length; i++)
{

    bool x = decimal.TryParse(values[i], out result);

    if (x)
    {
        sum = sum + result;

    }

    else
    {
        message = message + values[i];

    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sum}");

//It's necessary to implement the following business rules in your code logic:

//Rule 1: If the value is alphabetical, concatenate it to form a message.


//Rule 2: If the value is numeric, add it to the total.

//Rule 3: The result should match the following output:
//Message: ABCDEF
//Total: 68.3

