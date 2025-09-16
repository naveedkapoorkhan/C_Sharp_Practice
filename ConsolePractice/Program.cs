string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal result = 0;
string messa = "";
decimal sum = 0m;
for (int i = 0; i < values.Length; i++)
{
    bool valid = decimal.TryParse(values[i], out result);
    if (valid)
    {
        sum = sum + result;

    }
    else
    {
        messa = messa + values[i];
    }
}

Console.WriteLine(sum);
//Console.WriteLine(messa);


int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = (value2 / (decimal)value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = (value3 / value1);
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");



string[] pallets = ["B14", "A11", "B12", "A13"];

pallets[0] = pallets[1];
pallets[0] = "kabeer";
Console.WriteLine(pallets[0]);

Console.WriteLine("mmmmmmmmmmmm");
string[] b;
b = pallets;
foreach (var item in b)
{
    Console.WriteLine($"---{item}");
}

Console.WriteLine($"Before:{pallets[0]}");
Console.WriteLine($"Before:{pallets[1]}");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"after:--{pallets[0]}");
Console.WriteLine($"after:--{pallets[1]}");


foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

