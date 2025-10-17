


////string message = "Find what is (inside the parentheses)";

////int openingPosition = message.IndexOf('(');
////int closingPosition = message.IndexOf(')');

////Console.WriteLine(openingPosition);//13
////Console.WriteLine(closingPosition);//36


////Add code to retrieve the value between parenthesis

////string message = "Find what is (inside the parentheses)";

////int openingPosition = message.IndexOf('(');
////int closingPosition = message.IndexOf(')');
////openingPosition = openingPosition + 1;
////// =
////int length = closingPosition - openingPosition;
////Console.WriteLine($"length:{length}");//23
////Console.WriteLine(message.Substring(openingPosition , length));//13,23//inside the parentheses


////in this case length is not calculated correctly so ) see in output
////string message = "Find what is (inside the parentheses)";

////int openingPosition = message.IndexOf('(');
////int closingPosition = message.IndexOf(')');

////int length = closingPosition - openingPosition;
////Console.WriteLine($"length:{length}");//23
////Console.WriteLine(message.Substring(openingPosition, length));//13,23//inside the parentheses


////string message = "What is the value <span>between the tags</span>?";

////int openingPosition = message.IndexOf("<span>");
////int closingPosition = message.IndexOf("</span>");

////openingPosition += 6;
////int length = closingPosition - openingPosition;
////Console.WriteLine(message.Substring(openingPosition, length));


////string message = "What is the value <span>between the tags</span>?";

////const string openSpan = "<span>";
////const string closeSpan = "</span>";

////int openingPosition = message.IndexOf(openSpan);
////int closingPosition = message.IndexOf(closeSpan);
////int openingPosition1 = message.IndexOf("is");
////Console.WriteLine(openingPosition);
////Console.WriteLine(closingPosition);
////Console.WriteLine(openingPosition1);

////openingPosition += openSpan.Length;
////int length = closingPosition - openingPosition;
////Console.WriteLine(message.Substring(openingPosition, length));

////string message = "hello there!";
////int first_h = message.IndexOf('h');
////int last_h = message.LastIndexOf('e');

////Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");



////string message = "(What if) I am (only interested) in the last (set of parentheses)?";
////int openingPosition = message.LastIndexOf('(');
////Console.WriteLine("openting position"+openingPosition);
////openingPosition += 1;
////int closingPosition = message.LastIndexOf(')');
////Console.WriteLine("closing position"+closingPosition);
////int length = closingPosition - openingPosition;
////Console.WriteLine("length"+length);
////Console.WriteLine(message.Substring(openingPosition, length));

////string message = "(What if) there are (more than) one (set of parentheses)?";
////while (true)
////{
////    int openingPosition = message.IndexOf('(');
////The IndexOf() method returns -1 if it can't find the input parameter in the string.
////You merely check for the value -1 and break out of the loop.
////    if (openingPosition == -1) break;

////    openingPosition += 1;
////    int closingPosition = message.IndexOf(')');
////    int length = closingPosition - openingPosition;
////    Console.WriteLine(message.Substring(openingPosition, length));

////    // Note the overload of the Substring to return only the remaining 
////    // unprocessed message:
////    message = message.Substring(closingPosition + 1);
////}

////string message = "Hello, world!";
////char[] charsToFind = { 'h', 'e', 'i' };
////int index = message.IndexOfAny(charsToFind);
////Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
////Person person = new Person();
////person.getAge();
////Person person1 = new Person();
////person1.getAge();
////Person person2 = new Person();
////person2.getAge();
////Person person3 = new Person();
////person3.getAge();
////Person person4 = new Person();
////person4.getAge();

////List<Person > list = new List<Person>();
////list.Add(person.age);
////list.Add(person1.age);
////list.Add(person2.age);
////list.Add(person3.age);
////list.Add(person4.age);



////foreach (var lists in list)
////{
////    Console.WriteLine(lists);
////}
////List<Person> list = new List<Person>();

////for (int i = 0; i < 5; i++)
////{
////    Person p = new Person();
////    p.getAge();
////    list.Add(p); // store person object
////}

////// Print ages of all persons
////foreach (var p in list)
////{
////    Console.WriteLine(p.age);
////}
////List<Person> people = new List<Person>();

////for (int i = 0; i < 3; i++) // ask 3 persons (you can change)
////{
////    Person p = new Person();
////    p.GetDetails();
////    people.Add(p);
////}

////// Print all persons
////foreach (var p in people)
////{
////    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
////}

//String first = "Hello";
//String second = "World";
//Int32 first2 = 555;

//Console.WriteLine("{0} {1} {2} {0} {1} {2} {0} {1} {2} ", first, second, first2, first, second, first2, first, second, first2);
//Console.WriteLine(second.GetHashCode());




//int result = 0;
//string vowel = "aeiouAEIOU";
//char[] charArray = vowel.ToCharArray();
//void findVowels(string vol)
//{
//    for (int i = 0; i < vowel.Length; i++)
//    {
//        if (charArray.Contains(vol[i])== vowel.Contains(vol[i]) && charArray.Contains(vol[i]) == vowel.Contains(vol[i]))
//        {

//            result += 1;
//        }
//        else
//        {
//            result = 0;
//        }


//    }
// Console.WriteLine(result);
//}

//findVowels("naveed");



//Vehical vehical = new Vehical(3,"kabeer");

/*Abstraction → “Hide the unnecessary, show what matters.”

Simple idea:
Show what something does, not how it does it.

Everyday example:
When you drive a car — you use the steering, brake, and accelerator.
You don’t care how the engine or brakes are implemented — that’s abstraction.
*/

//Code Example


//Car car = new Car {A=2,B="Naveed" };
//car.B = "kabeer";
//Console.WriteLine(car.B);
