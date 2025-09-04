//////string message = "The quick brown fox jumps over the lazy dog.";
//////bool result = message.Contains("dog");
//////Console.WriteLine(result);
//////bool hasFox = message.Contains("fox");
//////if (hasFox)
//////{
//////    Console.WriteLine("yes hasfox");
//////}

////Random dice = new Random();

////int roll1 = dice.Next(1, 7);
////int roll2 = dice.Next(1, 7);
////int roll3 = dice.Next(1, 7);

////int total = roll1 + roll2 + roll3;

////Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//////if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
//////{
//////    Console.WriteLine("You rolled doubles! +2 bonus to total");
//////    total += 2;
//////    Console.WriteLine($"New total is {total}");


//////    if ((roll1 == roll2) && (roll2 == roll3))
//////    {
//////        Console.WriteLine("You rolled triples! +6 bonus to total!");
//////        total += 6;
//////        Console.WriteLine($"new total is {total}");
//////    }
////if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
////{
////    if ((roll1 == roll2) && (roll2 == roll3))
////    {
////        Console.WriteLine("You rolled triples!  +6 bonus to total!");
////        total += 6;
////    }
////    else
////    {
////        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
////        total += 2;
////    }
////}

//////if (total>=15)
//////    {
//////        Console.WriteLine("You win the Game!");
//////    Console.WriteLine($"new score is {total}");
//////    }
//////    else
//////    {
//////        Console.WriteLine("You lose the Game!");
//////    Console.WriteLine($"new total is {total}");
//////    }
////if (total >= 16)
////{
////    Console.WriteLine("You win a new car!");
////}
////else if (total >= 10)
////{
////    Console.WriteLine("You win a new laptop!");
////}
////else if (total == 7)
////{
////    Console.WriteLine("You win a trip for two!");
////}
////else
////{
////    Console.WriteLine("You win a kitteni!");
////}

////string[] animal = new string[3] { "cat", "dog", "fox" };
////Random rand = new Random();
////string randomAnimal = animal[rand.Next(animal.Length)];
////Console.WriteLine(randomAnimal);


//Random random = new Random();
//int daysUntilExpiration = random.Next(12);
//int discountPercentage = 0;

//// Your code goes here
//if (daysUntilExpiration == 0)
//{
//    Console.WriteLine("Your subscription will expire soon. Renew now!\r\n");
//}
//else if (daysUntilExpiration == 1)
//{
//    discountPercentage = 20;
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} day! Renew now and save {discountPercentage}%!");
//}
//else if (daysUntilExpiration <= 5)
//{
//    discountPercentage = 10;
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days! Renew now and save {discountPercentage}%!");
//}
//else if (daysUntilExpiration <= 10)
//{
//    discountPercentage = 5;
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days! Renew now and save {discountPercentage}%!");
//}
//else
//{
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//}


//You've been asked to add a feature to your company's software.
//    The feature is intended to award the  bosnus according to the age of the employee. 
//    you need to display the bonus of 20 thousand if his age is above 60 and below 80;
//Add 10 thousand if his age is above 60 and below 80 but the lucky number is below 40 
//    and greater than 20; if his age is smaller than 60 and greater or equal than 40 and lucky number 
//    is in range of 45 and 60. Add50 k
Random random = new Random();
int age = random.Next(40, 81);
int luckyNumber = random.Next(20, 61);
Console.WriteLine($"Age = {age}, Lucky Number = {luckyNumber}");
int bonus = 0;
if (age >= 60 && age <= 80)
{
    bonus = 20000;
    Console.WriteLine($"your bonus is {bonus} because your age is {age}");
    if (luckyNumber > 20 && luckyNumber <40)
    {
        bonus += 10000;
        Console.WriteLine($"your bonus is {bonus} because your age is {age} and lucky number is {luckyNumber}");

    }
}
 else if (age >=40 && age<=60)
   {
    if (luckyNumber >=45 && luckyNumber <= 60)
    {
        
        bonus = 50000;
        Console.WriteLine($"your bonus is {bonus} because your age is {age} and lucky number is {luckyNumber}");
    }
    else
    { Console.WriteLine("no bonus"); }
}
