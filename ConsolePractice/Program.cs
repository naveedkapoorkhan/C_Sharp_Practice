//Learning objectives
//In this module you will:


//Split a string into an array of strings or characters (chars).
//Join array elements into a string.

//Exercise - Discover Split() and Join()

//string name = "naveed";
//char[] characters=name.ToCharArray();

//string[] stringArray=name.Split("");
//Array.Reverse(stringArray);
//Array.Reverse(characters);
//foreach(char c in characters)
//{
//    Console.WriteLine(c);
//}

//foreach (string item in stringArray)
//{
//    Console.WriteLine(item);
//}


//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//string result = new string(valueArray);
//Console.WriteLine(result);


//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//// string result = new string(valueArray);
//string result = string.Join(",", valueArray);
//Console.WriteLine(result);


//Here are a few key points to remember when working with strings and arrays:

//To create an array, use methods like ToCharArray() and Split()
//To turn the array back into a single string, use methods like Join(), or create a new string passing in an array of char

string value = "a-b-c-1-2-3";
string[] arr=value.Split("-");

int num = int.Parse(arr[5]);
num = num + 1;

arr[5] = num.ToString();
string newValue = string.Join("-",arr);

    Console.WriteLine(newValue);


//when to use join first and when to use split first if string have ",/-" use first split otherwise make them char[] then join the split ok
string values = "abc123";
char[] valueArray = values.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);

string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}





string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result1 = String.Join(" ", newMessage);
Console.WriteLine(result1);

////
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] NEWaRRAY = orderStream.Split(',');
Array.Sort(NEWaRRAY);

foreach (var item in NEWaRRAY)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}