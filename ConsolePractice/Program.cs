//Declaration of a 2D Array
//int[,] studentScore;
//delaration of a 2D Array with size
//studentScore = new int[3, 3];
//declaration and initialization of a 2D Array with values
//int[,] studentScore2 = new int[3, 3] { { 90, 80, 70 }, { 85, 75, 65 }, { 88, 78, 68 } };
//declaration and initialization of a 2D Array with shorthand method
//int[,] studentScore3 = { { 90, 80, 70 }, { 85, 75, 65 }, { 88, 78, 68 } }
//;
//string[] studentNames = { "John", "Jane", "Jim" };

//studentScore3[1, 1] = 95; //Updating an element in a 2D Array
//Accessing elements of a 2D Array
//Console.WriteLine($"{studentScore3[1, 1]}");
//Console.WriteLine($"{studentScore3[0, 0]}");
//Console.WriteLine($"number of row :{studentScore3.GetLength(0)}");
//Console.WriteLine($"number of column :{studentScore3.GetLength(1)}");
//Iterating through a 2D Array using  for each loop
//foreach (int score in studentScore3)
//    {

//        Console.Write($"  {score}  ");
//    }
//Uses arrays to store student names and assignment scores.
//int[,] studentScore3 = { { 90, 80, 70 }, { 85, 75, 65 }, { 88, 78, 68 } }
//;
//string[] studentNames = { "John", "Jane", "Jim" };
//Console.WriteLine($"StudentName\t\tGrade\t\tLetter Grade");

//Iterating through a 2D Array using nested for loop
//for (int i = 0; i < studentNames.Length; i++)
//    {
//        int sum = 0;


//        for (int j = 0; j < studentScore3.GetLength(0); j++)
//        {
//            // Console.WriteLine($"Assignment {j+1} : {studentScore3[i,j]} Marks ");
//            sum = sum + studentScore3[i, j];


//        }
//        double average = sum / studentScore3.GetLength(0);



//        if (average >= 90 && average <= 100)
//        {
//            Console.WriteLine($"{studentNames[i]}{average,10} A");

//        }
//        else if (average >= 80 && average < 90)
//        {
//            Console.WriteLine($"{studentNames[i]}   {average} B");
//        }
//        else if (average >= 70 && average < 80)
//        {
//            Console.WriteLine($"{studentNames[i]}   {average} C");
//        }
//        else if (average >= 60 && average < 70)
//        {
//            Console.WriteLine($"{studentNames[i]}   {average} D");
//        }
//        else
//        {
//            Console.WriteLine($"{studentNames[i]}   {average} F");
//        }
//    }

//bool flag = true;
//if (flag)
//{
//    int value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}

//Console.WriteLine($"Inside the code block: {value}");


//bool flag = true;
//int value = 0;

//if (flag)
//{
//    Console.WriteLine($"Inside the code block: {value}");
//}

//value = 10;
//Console.WriteLine($"Outside the code block: {value}");



//Code sample 1
//bool flag = true;
//int value;

//if (flag)
//{
//    value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}

//Console.WriteLine($"Outside the code block: {value}");

//Code sample 2
//int value;

//if (false)
//{
//    value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}

//Console.WriteLine($"Outside the code block: {value}");
//Code sample 2
//int value;

//if (true)
//{
//    value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}

//Console.WriteLine($"Outside the code block: {value}");

