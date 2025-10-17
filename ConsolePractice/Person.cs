class Person
{
    public string Name;
    public int Age;

    public void GetDetails()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter age: ");
        Age = Convert.ToInt32(Console.ReadLine());
    }
}

