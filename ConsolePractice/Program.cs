
//using System.Numerics;
//using System.Security.Cryptography.X509Certificates;

//string StudentName,StudentCnic,StudentGraduationYear,StudentAdmissionYear;
//string wow = @"Generating invoices for customer ""Contoso Corp"" ...

//Invoice: 1021           Complete!
//Invoice: 1022           Complete!

//Output Directory:
//c:\invoices";

// StudentName = @"'Usman'";
// StudentCnic = "16101-8892132-5";
//StudentGraduationYear = "30/09/1996";
//StudentAdmissionYear = "30/09/2000";

//string heart = "\u2665";     // ♥
//string smile = "\u263A";     // ☺
//string arrow = "\u2192";     // →
//string alpha = "\u03B1";     // α
//string greet = "naveed";
//string message = $"Hi {greet}";
//Console.WriteLine("\"StudentName\"\t\tStudentCnic\t\tAdmissionYear\t\tGraduationYear");
//Console.WriteLine($"{StudentName}\t\t\t{StudentCnic}\t\t\"{StudentAdmissionYear}\"\t\t{StudentGraduationYear}");
//Console.WriteLine(wow);
//Console.WriteLine(heart);   // ♥
//Console.WriteLine(smile);   // ☺
//Console.WriteLine(arrow);   // →
//Console.WriteLine(message);
//View English output:
//  c:\Exercise\ACME\data.txt

//Посмотреть русский вывод:
//  c:\Exercise\ACME\ru-RU\data.txt

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
c:\Excercise\{projectName}\data.txt

Посмотреть русский вывод::
c:\Excercise\{projectName}\ru-RU\data.txt



");