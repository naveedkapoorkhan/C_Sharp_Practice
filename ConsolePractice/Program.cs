//Learning objectives
//In this module you will:

//Sort and reverse the order of array elements.
//Clear and resize the elements of an array.
//Split a string into an array of strings or characters (chars).
//Join array elements into a string.




//Sort and reverse the order of array elements.

string[] pallets = ["B14", "A13", "B12", "A11"];

Console.WriteLine("Sorted...");
//Array.Sort(pallets);
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("Reversed...");
//Array.Sort(pallets);
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


//Clear and resize the elements of an array.


string[] pallets1 = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets1, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets1.Length}");
foreach (var pallet1 in pallets1)
{
    Console.WriteLine($"----{pallet1}");
}






string[] palletss = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(palletss, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {palletss.Length}");
foreach (var pallets3 in palletss)
{
    Console.WriteLine($"-- {pallets3}");
}

Console.WriteLine("");
//Array.Resize(ref palletss, 6);
Array.Resize(ref palletss,7);
Console.WriteLine($"Resizing 6 ... count: {palletss.Length}");

palletss[4] = "C01";
palletss[5] = "C02";
palletss[6] = "Naveed";


foreach (var palletsss in palletss)
{
    Console.WriteLine($"-- {palletsss}");
}

Console.WriteLine("");
//Array.Resize(ref palletss, 6);
Array.Resize(ref palletss, 4);
Console.WriteLine($"Resizing 6 ... count: {palletss.Length}");

//Notice that calling Array.Resize() didn't eliminate the first two null elements. Rather, it removed the last three elements. Notably, last three elements were removed even though they contained string values.


foreach (var palletsss in palletss)
{
    Console.WriteLine($"-- {palletsss}");
}



