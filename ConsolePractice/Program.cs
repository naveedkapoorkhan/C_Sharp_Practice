
///*Task 10 – Traffic Signal Simulation (10 marks)

//A traffic system tests signals randomly.

//Generate random number 1–3:

//1 → Red → Stop

//2 → Yellow → Get Ready

//3 → Green → Go

//✅ Example Output:
//Signal = Yellow → Get Ready
//*/
//// Generate random number between 1 and 3
//Random random = new Random();


//int trafficSignal = random.Next(1, 4);


////Print the signal and action
//// 1 → Red → Stop
//if (trafficSignal == 1)
//{
//    Console.WriteLine("Signal = Red → Stop");
//}
//// 2 → Yellow → Get Ready
//else if (trafficSignal == 2)
//{
//    Console.WriteLine("Signal = Yellow → Get Ready");
//}
//// 3 → Green → Go
////////else
////////{
////////    Console.WriteLine("Signal = Green → Go");
////////}

/////////*
////////Task 8 – Number Comparison (5 marks)
////////A program compares two values.
////////Generate two random numbers between 1–100.
////////Print which one is greater or if they are equal.
////////✅ Example Output:
////////Numbers = 45 and 72 → 72 is greater
//////// */

//// Generate two random numbers between 1 and 100
//Random rand = new Random();
//// Generate first number
//int number1 = rand.Next(1, 101);
//// Generate second number
//int number2 = rand.Next(1, 101);
//// Compare the numbers and print the result
//if (number1 > number2)
//{
//    Console.WriteLine($"Numbers = {number1} and {number2}  →  {number1} is greater");
//}
//// If second > first → "Second number is greater".
//else if (number2 > number1)
//{
//    Console.WriteLine($"Numbers = {number1} and {number2} → {number2} is greater");
//}
//// Else → "Both are equal".
//else
//{
//    Console.WriteLine($"Numbers = {number1} and {number2} → Both are equal");
//}

///*Task 10 – Traffic Signal Simulation (10 marks)
///*
///*
///
///*
using System.Collections.Generic;
///*
// 10. Traffic Signal Simulation
//Ask user to enter a signal color (red, yellow, green).
//If red → "Stop".
//If yellow → "Get ready".
//If green → "Go".*/

//// Ask user to enter a signal color (red, yellow, green).
//Console.WriteLine("Please Enter Signal Color");
//// Read user input
//string signalColor = Console.ReadLine();
////if user enter red in smaller its should also work but if user enter RED in capital its should also work because we are using ToLower() method
//if (signalColor.ToLower() == "red")
//{
//    Console.WriteLine("Stop");
//}
//else if (signalColor.ToLower() == "yellow")
//{
//    Console.WriteLine("Get ready");
//}
//else if (signalColor.ToLower() == "green")
//{
//    Console.WriteLine("Go");
//}
//else
//{
//    Console.WriteLine("Invalid color");
//}
///*
// 8. Number Comparison

//Input two numbers.

//If first > second → print "First number is greater".

//If second > first → "Second number is greater".

//Else → "Both are equal".
//*/


//// Ask user to enter first number
//Console.WriteLine("Please Enter Your First Number");
//int firstNumber = int.Parse(Console.ReadLine());
//// Ask user to enter second number
//Console.WriteLine("Please Enter Your Second Number");
//int secondNumber = int.Parse(Console.ReadLine());
//// Compare the numbers and print the result

//if (firstNumber > secondNumber)
//{
//    Console.WriteLine("First number is greater");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine("Second number is greater");
//}
//else
//{
//    Console.WriteLine("Both are equal");
//}



//Console.WriteLine("Enter a fruit (apple, banana, cherry): ");
//string fruit = Console.ReadLine().ToLower();


//switch (fruit)
//{
//    case "apple":
//        Console.WriteLine($"App will display information for apple.");
//        break;

//    case "banana":
//        Console.WriteLine($"App will display information for banana.");
//        break;

//    case "cherry":
//        Console.WriteLine($"App will display information for cherry.");
//        break;

//   default:
//        Console.WriteLine("invalid");
//        break;
//}

//int employeeLevel = 300;
//string employeeName = "Naveed Khan Kapoor";

//string title = "Name mising";

//switch (employeeLevel)
//{
//    case 100:
//        title = "Junior Associate";
//        break;
//    case 200:
//        title = "Senior Associate";
//        return;
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default:
//        title = "Associate";
//        break;
//}

//////Console.WriteLine($"{employeeName}, {title}");

////// SKU = Stock Keeping Unit. 
////// SKU value format: <product #>-<2-letter color code>-<size code>
////using System;

/////*Task 10 – Traffic Signal Simulation (10 marks)
/////*
/////*
/////*
//string sku = "01-MN-L";

//string[] product = sku.Split('-');

//string type = "";
//string color = "";
//string size = "";
//switch(product[0])
//{
//    case "01":
//        type = "Sweat shirt";
//        break;
//    case "02":
//        type = "T-Shirt";
//        break;
//    case "03":
//        type = "Sweat pants";
//        break;
//    default:
//        type = "Other";
//        break;
//}
//switch(product[1])
//{
//    case "BL":
//        color = "Black";
//        break;
//    case "MN":
//        color = "Maroon";
//        break;
//    default:
//        color = "White";
//        break;
//}
//switch(product[2])
//{
//    case "S":
//        size = "Small";
//        break;
//    case "M":
//        size = "Medium";
//        break;
//    case "L":
//        size = "Large";
//        break;
//    default:
//        size = "One Size Fits All";
//        break;
//}

//Console.WriteLine($"Product: {size} {color} {type}");
////Product: Large Maroon Sweat shirt
///
//if (product[0] == "01")
//{
//    type = "Sweat shirt";
//}
//else if (product[0] == "02")
//{
//    type = "T-Shirt";
//}
//else if (product[0] == "03")
//{
//    type = "Sweat pants";
//}
//else
//{
//    type = "Other";
//}

//if (product[1] == "BL")
//{
//    color = "Black";
//}
//else if (product[1] == "MN")
//{
//    color = "Maroon";
//}
//else
//{
//    color = "White";
//}

//if (product[2] == "S")
//{
//    size = "Small";
//}
//else if (product[2] == "M")
//{
//    size = "Medium";
//}
//else if (product[2] == "L")
//{
//    size = "Large";
//}
//else
//{
//    size = "One Size Fits All";
//}

//Console.WriteLine($"Product: {size} {color} {type}");
////Product: Large Maroon Sweat shirt





//int i = 0;
//while (i < 5)
//{
//i++;
//Console.WriteLine(i);

//}

//int a = 0;
//while (a < 5)
//{

//Console.WriteLine(a);
//a++;

//}

//for (int j = 0; j < 5; j--)
//{
//Console.WriteLine(j);
//}
//bool condition = false;
//while (!condition)
//{
//    //do { 
//    //Console.WriteLine("please enter correct userName Password Agin");
//    string userName = "naveed";
//    Console.WriteLine("Please Enter Your Name");
//    string input = Console.ReadLine();

//    string password = "12324n";
//    Console.WriteLine("Please Enter Your Password");
//    string inputPassword = Console.ReadLine();
//    if (input == userName && inputPassword == password)
//    {
//        Console.WriteLine("Welcome to the system");
//        condition = false;

//    }
//    else
//{
//    Console.WriteLine("Invalid username or password");
//        Console.WriteLine("Please Enter credential again ");
//}}
////while(condition);





//string userName = "naveed";
//Console.WriteLine("enter user name");
//string inputUserName= Console.ReadLine();
//string password = "12324n";
//Console.WriteLine("enter password");
//string inputPassword = Console.ReadLine();
//while (!(inputUserName==userName && inputPassword == password)) {
//    Console.WriteLine("invalid cradential");
//    Console.WriteLine("enter  credential again ");
//   Console.WriteLine("enter user name");
//    inputUserName = Console.ReadLine();
//    Console.WriteLine("enter password");
//    inputPassword = Console.ReadLine();
//}
//Console.WriteLine("Welcome to the system");

//for(int i=0 ;!(inputUserName == userName && inputPassword == password); i++)
//for loop is not ideal for this scenario but still we can use it
//because we dont know how many times user will enter wrong credential
//so its better to use while loop but still we can use for loop
//because we can use for loop without initialization and increment/decrement
//and just use the condition part
//here for loop act like  while loop without initialization and increment/decrement
//for (; !(inputUserName == userName && inputPassword == password);)

//{
//    Console.WriteLine("invalid cradential");
//    Console.WriteLine("enter  credential again ");
//    Console.WriteLine("enter user name");
//    inputUserName = Console.ReadLine();
//    Console.WriteLine("enter password");
//    inputPassword = Console.ReadLine();
//}
//Console.WriteLine("Welcome to the system");

//for(; ;)
//{
//    Console.WriteLine("infinite loop");
//}
//do
//{
//    Console.WriteLine("infinite loop");
//}
//while (true);


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);

//}
//int a = 0;
//while (a < 5)
//{
//    Console.WriteLine(a);    // print first
//    a++;                     // then increment
//}
//Console.WriteLine(a);
//for (int i = 3; i >= 0; i--)
//{
//    Console.WriteLine(i--);   // post-decrement inside
//}
//int i;
//for ( i = 0; i < 3; i++)
//{
//    Console.WriteLine("Inside loop: " + i);
//}
//Console.WriteLine("After loop: " + i);
//for (int i = 10; i >= 0; --i)
//{
//    Console.WriteLine(i);
//}
//string[] names = { "Alex", "Addie", "David", "Michael" };
//for (int i = names.Length - 1; i >= 0; i--)
//{

//    if (names[i].Contains('A'))
//    {
//        Console.WriteLine(names[i]);
//         // Skip the rest of the loop when the name is "David"


//    }

//}

//string[] names = { "Alex", "Eddie", "David", "Michael" };

//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i] == "David")
//    {
//        Console.WriteLine(names[i]);
//        names[i] = "Sammy";
//    }
//}

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//for (int i = 1; i <=100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine($"{i} - fizzbuzz");
//    }

//    else if (i % 5 == 0)
//    {
//        Console.WriteLine($"{i} - buzz");
//    }
//    else if (i % 3 == 0)
//    {

//        Console.WriteLine($"{i} - fizz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}





//int[] numbers= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//foreach (var number in numbers)
//{

//    Console.WriteLine(number);
//}

//float[] tempreture=new float[5];
//Random random = new Random();

//for (int i = 0; i < tempreture.Length; i++)
//{

//    tempreture[i] = random.Next();

//    Console.WriteLine($"tempreture {tempreture[i]}");

//}


//string toss="head";
//Random random = new Random();
//int coinToss = random.Next(1, 3);
//string ok = (coinToss==1) ? toss = "head" : toss = "tail";
//Console.WriteLine(ok);

//        string permission = "12343";
//if (permission.Contains('2'))
//{
//    Console.WriteLine("you can enter the club");
//}
//else
//{
//    Console.WriteLine("you cannot enter the club");
//}


//string[] candies = { "Red", "Green", "Rotten", "Blue" };

//foreach (string candy in candies)
//{
//    if (candy == "Rotten")
//    {
//        Console.WriteLine("Yuck! Rotten candy. Stop eating.");
//        continue; // stop the whole loop
//    }
//    Console.WriteLine($"Eating {candy} candy");
//}


//do
//{
//    Console.WriteLine("Yuck! Rotten candy. Stop eating.");
//} while (true);
//Random random =new Random();
//int StopLoopNumber =0;
//do
//{
//    StopLoopNumber = random.Next(1, 11);

//    Console.WriteLine($"StopLoopNUmber:{StopLoopNumber}");
//}
//while (StopLoopNumber!=7);

//for(int i = 0; i < 10; i++)
//{
//    if(i == 2)
//    {
//        i = 10;
//    }
//    Console.WriteLine(i);
//}

//Random random = new Random();
//int current = random.Next(1, 11);

///*
//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);
//*/

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");

using System.Threading;

///*Task 10 – Traffic Signal Simulation (10 marks)
///*
///*
///
///*
//int heroHealthPoint = 10;
//int monsterHealthPoint = 10;

//Random attacks = new Random();
//int attacksByHero = 0;
//int attacksByMonster = 0;

//for (; monsterHealthPoint >= 0 && heroHealthPoint >= 0;)
//{
//    attacksByHero = attacks.Next(1, 10);
//    attacksByMonster = attacks.Next(1, 10);
//    heroHealthPoint -= attacksByMonster;


//    Console.WriteLine($"hero was damaged By Monster by {attacksByMonster} health loss and now has presnt health in 10 is  {heroHealthPoint} health.");
//    monsterHealthPoint -= attacksByHero;

//    Console.WriteLine($"Monster was damaged By hero by {attacksByHero} health loss and now has presnt health in 10 is  {monsterHealthPoint} health.");

//}
//string whoWin = heroHealthPoint > monsterHealthPoint ? "hero win" : "monster win";
//Console.WriteLine($"who win the game\n{whoWin}");

//Console.WriteLine("enter your number");
//string number = Console.ReadLine();
//int Result = 0;
//bool validNumber = false;
//validNumber = int.TryParse(number, out int result);
//Console.WriteLine($"validenumber:{validNumber}\n number is :{result}");
//while (!validNumber)
//{

//    Console.WriteLine("enter your number");

//}
//int a = new int();   // same as int a = 0;
// a = 5;
//int b =new int();
//b = a;
//b = 6;

//Console.WriteLine(a); // Output: 0
//Console.WriteLine(b); // Output: 5

// float x=2.0156f;
//int y = (int)(x);
//x = y;
//Console.WriteLine(y);
//Console.WriteLine(x);
//int p=new int();
//string o=p.ToString();
//Console.WriteLine(o);

//Console.WriteLine("Signed integral types:");

//Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
//Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
//Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
//Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


//Console.WriteLine("unSigned integral types:");
//Console.WriteLine($"byte  : {byte.MinValue} to {byte.MaxValue}");
//Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
//Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
//Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

//int[] data;
//data = new int[5]; 
//int[] data = new int[5];
enum Day
{
    Sunday,    // 0
    Monday,    // 1
    Tuesday    // 2
}

class Program
{
    static void Main()
    {
        
        Console.WriteLine(Day.Monday);
        Day var;
        var=Day.Sunday;
        Day var1 = var;
        var1 = Day.Tuesday;
        //=Day.Monday;// Output: Monday
        Console.WriteLine(var);
        Console.WriteLine(var1);
        // Console.WriteLine((int)today);  // Output: 1
    }
}




