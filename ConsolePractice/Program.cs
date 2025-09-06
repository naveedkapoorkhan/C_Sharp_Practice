Random random = new Random();
int seatNumber0 = random.Next(1, 100);
int seatNumber1 = random.Next(1, 100);
int seatNumber2 = random.Next(1, 100);
int seatNumber3 = random.Next(1, 100);
int seatNumber4 = random.Next(1, 100);
////convert random numbers to string
////string seatNumber0 = random.Next(1, 100).ToString("00");
////string seatNumber1 = random.Next(1, 100).ToString("00");
////string seatNumber2 = random.Next(1, 100).ToString("00");
////string seatNumber3 = random.Next(1, 100).ToString("00");
////string seatNumber4 = random.Next(1, 100).ToString("00");

//// Array Declaration and Initialization
int[] studentSeatNo;
studentSeatNo = new int[5];
//{1,44,3,4,5,6,78,87,87 };
//string[] studentNames = new string[] { "John", "Jane", "Doe", "Alice", "Bob" };


//foreach (int seatNo in studentSeatNo)
//{
//    Console.WriteLine($"Student Seat Number: {seatNo} to");
//}

////assigning value by index manually
////studentSeatNo[0] = 1;
////studentSeatNo[1] = 11;
////studentSeatNo[2] = 111;
////studentSeatNo[3] = 1111;
////studentSeatNo[4] = 11111;
//// Assigning values to array elements while using random numbers
studentSeatNo[0] = seatNumber0;
studentSeatNo[1] = seatNumber1;
studentSeatNo[2] = seatNumber2;
studentSeatNo[3] = seatNumber3;
studentSeatNo[4] = seatNumber4;
Array.Sort(studentSeatNo);
foreach (int seatNo in studentSeatNo)
{
    Console.WriteLine($"Student Seat Number: {seatNo}");
}





