
//////////HERE WE WILL WORK WITH ARRAYS

//////////CREATE AN ARRAY

//////////DECLARE AN ARRAY 0 1 
////////int[] numbers;
//////////initialize
////////numbers = new int[2];
////////numbers[0] = 1;
////////numbers[1] = 2;
//////////numbers[2] = 3;
//////////numbers[3] = 4;
////////foreach (int number in numbers)
////////{
////////    Console.WriteLine(number);
////////}

//////////if you want to declare and initialize an array in one line
////////Console.WriteLine("declare and initialize an array in one line");
////////string[] students = new string[3];
////////students[0] = "John";   
////////students[1] = "Jane";
////////students[2] = "Jim";
////////foreach (string student in students)
////////{
////////    Console.WriteLine(student);
////////}

//////////if you want to shorthand array declaration and initialization with specifying the size
////////Console.WriteLine("shorthand array declaration and initialization");
////////char[] lettrs = new char[3] {'1','s','5'};
////////foreach (char lettr in lettrs)
////////{
////////    Console.WriteLine(lettr);
////////}

//////////if you want to shorthand array declaration and initialization without specifying the size
////////Console.WriteLine("shorthand array declaration and initialization");
////////char[] alphabets = new char[] { 'A', 's','2','2' };

////////foreach (char alpa in alphabets)
////////{
////////    Console.WriteLine(alpa);
////////}
//////////if you want to shorthand array declaration and initialization without specifying the size and the new keyword
////////Console.WriteLine("float array shorthand array declaration");
////////float[] pointsGrade=new float[2] {3.5f,4.0f};
////////foreach (float point in pointsGrade)
////////{
////////    Console.WriteLine(point);
////////}


//////////lets make an array of boolean
////////Console.WriteLine("boolean array");
////////bool[] answers = new bool[] { true, false, true };
////////foreach (bool answer in answers)
////////{
////////    Console.WriteLine(answer);
////////}

//////////lets make an array of classes
////////Console.WriteLine("array of classes");


////////Car[] cars=new Car[2];
////////cars[0]=new Car() { Make="Toyota", Model="Camry", Year=2020};
////////cars[1]=new Car() { Make="Honda", Model="Civic", Year=2021};
////////foreach (Car car in cars)
////////{
////////    car.display();
////////}


//////////set and get value of array
////////Console.WriteLine("set and get value of array");
////////int[] array1 = new int[2];
////////array1[0]=10;//set value
////////array1[1]=20;//set value
//////////now get the value
////////Console.WriteLine(array1[0]);//get value
////////Console.WriteLine(array1[1]);//get value
////////                             //you can also use a loop to set and get value of array

//////////to find size of array use Length property
////////Console.WriteLine($"size of array:{array1.Length}");

//////////the most shorthand way used for array declaration and initialization
////////Console.WriteLine("most shorthand way used for array declaration and initialization");
////////int[] inventary = { 100, 200, 300, 400 };
////////int sum = 0;
////////int room = 0;
////////foreach (int item in inventary)
////////{

////////    sum += item;

////////    room++;
////////    Console.WriteLine($"in room{room} contain {item}items and (running total is{sum}...)");


////////}
////////Console.WriteLine($"sum of inventary: {sum}");


////////string [] name = { "akbar", "basit", "kamran" ,"kashar"};
////////foreach (string n in name)
////////{
////////   if(n.StartsWith('k'))
////////    {
////////        Console.WriteLine(n);
////////    }

////////        if (n.Contains('t'))
////////        {
////////            Console.WriteLine(n);
////////        }

////////        if(n.EndsWith('r'))
////////        {
////////            Console.WriteLine(n);
////////    }
////////        if(n.Length>4)
////////        {
////////            Console.WriteLine(n);
////////    }
////////    if (n.Equals("basit"))
////////    {
////////        Console.WriteLine("you are a terrorist basit");
////////    }
////////    }

////////new key word use to tell compiler to take aas much place in memory as size 
////////look at the example but when new key word is used and you do not gave value  so the new key word reserved memory by default value
////////int 0 string null 
//////int[] numbersof;
//////numbersof = new int[2];
//////foreach (int x in numbersof)
//////{

//////    Console.WriteLine(x);
//////}
//////string[] numberso;
//////numberso = new string[2];
//////foreach (string l in numberso)
//////{

//////    Console.WriteLine(l);
//////}
//////bool[] ok;
//////ok = new bool[2];
//////foreach (bool h in ok)
//////{
//////    Console.WriteLine(h);
//////}

//////string text = "hello";
//////string upper = text.ToUpper();

//////DateTime now = DateTime.Now;

//////Console.WriteLine(now);


//////here wwe are going to call .net class library methods
//Random ran;
//ran = new Random();

//Console.WriteLine(ran.Next());

//string name = "naveed";
//if (name.Equals("naved"))
//{
//    return;
//}
//else
//{
//    return;
//}
Console.WriteLine("find largest value ");
int firstValue = 500;
int secondValue = 600;
int largerValue= Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);


