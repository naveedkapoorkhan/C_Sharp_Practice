using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Car
    {
       
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public void display() { Console.WriteLine($"YEAR:{Year}\t make: {Make}\t model: {Model}"); }
        
    }

