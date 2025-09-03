
//HERE WE WILL WORK WITH ARRAYS

//CREATE AN ARRAY

//DECLARE AN ARRAY 0 1 
int[] numbers;
//initialize
numbers = new int[2];
numbers[0] = 1;
numbers[1] = 2;
//numbers[2] = 3;
//numbers[3] = 4;
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//if you want to declare and initialize an array in one line
Console.WriteLine("declare and initialize an array in one line");
string[] students = new string[3];
students[0] = "John";   
students[1] = "Jane";
students[2] = "Jim";
foreach (string student in students)
{
    Console.WriteLine(student);
}

//if you want to shorthand array declaration and initialization with specifying the size
Console.WriteLine("shorthand array declaration and initialization");
char[] lettrs = new char[3] {'1','s','5'};
foreach (char lettr in lettrs)
{
    Console.WriteLine(lettr);
}

//if you want to shorthand array declaration and initialization without specifying the size
Console.WriteLine("shorthand array declaration and initialization");
char[] alphabets = new char[] { 'A', 's','2','2' };

foreach (char alpa in alphabets)
{
    Console.WriteLine(alpa);
}
//if you want to shorthand array declaration and initialization without specifying the size and the new keyword
Console.WriteLine("float array shorthand array declaration");
float[] pointsGrade=new float[2] {3.5f,4.0f};
foreach (float point in pointsGrade)
{
    Console.WriteLine(point);
}


//lets make an array of boolean
Console.WriteLine("boolean array");
bool[] answers = new bool[] { true, false, true };
foreach (bool answer in answers)
{
    Console.WriteLine(answer);
}

//lets make an array of classes
Console.WriteLine("array of classes");


Car[] cars=new Car[2];
cars[0]=new Car() { Make="Toyota", Model="Camry", Year=2020};
cars[1]=new Car() { Make="Honda", Model="Civic", Year=2021};
foreach (Car car in cars)
{
    car.display();
}


//set and get value of array
Console.WriteLine("set and get value of array");
int[] array1 = new int[2];
array1[0]=10;//set value
array1[1]=20;//set value
//now get the value
Console.WriteLine(array1[0]);//get value
Console.WriteLine(array1[1]);//get value
                             //you can also use a loop to set and get value of array

//to find size of array use Length property
Console.WriteLine($"size of array:{array1.Length}");