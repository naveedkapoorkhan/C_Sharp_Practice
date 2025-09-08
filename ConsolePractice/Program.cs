
/*Task 10 – Traffic Signal Simulation (10 marks)

A traffic system tests signals randomly.

Generate random number 1–3:

1 → Red → Stop

2 → Yellow → Get Ready

3 → Green → Go

✅ Example Output:
Signal = Yellow → Get Ready
*/
// Generate random number between 1 and 3
Random random = new Random();


int trafficSignal = random.Next(1, 4);


// Print the signal and action
// 1 → Red → Stop
if (trafficSignal == 1)
{
    Console.WriteLine("Signal = Red → Stop");
}
// 2 → Yellow → Get Ready
else if (trafficSignal == 2)
{
    Console.WriteLine("Signal = Yellow → Get Ready");
}
// 3 → Green → Go
else
{
    Console.WriteLine("Signal = Green → Go");
}

/*
Task 8 – Number Comparison (5 marks)
A program compares two values.
Generate two random numbers between 1–100.
Print which one is greater or if they are equal.
✅ Example Output:
Numbers = 45 and 72 → 72 is greater
 */

// Generate two random numbers between 1 and 100
Random rand = new Random();
// Generate first number
int number1 = rand.Next(1, 101);
// Generate second number
int number2 = rand.Next(1, 101);
// Compare the numbers and print the result
if (number1 > number2)
{
    Console.WriteLine($"Numbers = {number1} and {number2}  →  {number1} is greater");
}
// If second > first → "Second number is greater".
else if (number2 > number1)
{
    Console.WriteLine($"Numbers = {number1} and {number2} → {number2} is greater");
}
// Else → "Both are equal".
else
{
    Console.WriteLine($"Numbers = {number1} and {number2} → Both are equal");
}

/*
 10. Traffic Signal Simulation
Ask user to enter a signal color (red, yellow, green).
If red → "Stop".
If yellow → "Get ready".
If green → "Go".*/

// Ask user to enter a signal color (red, yellow, green).
Console.WriteLine("Please Enter Signal Color");
// Read user input
string signalColor = Console.ReadLine();
//if user enter red in smaller its should also work but if user enter RED in capital its should also work because we are using ToLower() method
if (signalColor.ToLower() == "red")
{
    Console.WriteLine("Stop");
}
else if (signalColor.ToLower() == "yellow")
{
    Console.WriteLine("Get ready");
}
else if (signalColor.ToLower() == "green")
{
    Console.WriteLine("Go");
}
else
{
    Console.WriteLine("Invalid color");
}
/*
 8. Number Comparison

Input two numbers.

If first > second → print "First number is greater".

If second > first → "Second number is greater".

Else → "Both are equal".
*/


// Ask user to enter first number
Console.WriteLine("Please Enter Your First Number");
int firstNumber = int.Parse(Console.ReadLine());
// Ask user to enter second number
Console.WriteLine("Please Enter Your Second Number");
int secondNumber = int.Parse(Console.ReadLine());
// Compare the numbers and print the result

if (firstNumber > secondNumber)
{
    Console.WriteLine("First number is greater");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine("Second number is greater");
}
else
{
    Console.WriteLine("Both are equal");
}




