using System;

namespace Day_15_Assignment_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Iphone 12");
            Laptop laptop = new Laptop("HP Pavilion");

            smartphone.Connect();
            smartphone.Charge(70); 
            Console.WriteLine("Smartphone Information:");
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            laptop.Connect();
            laptop.Charge(100); 
            Console.WriteLine("Laptop Information:");
            Console.WriteLine(laptop.Display());

            Console.ReadKey();
        }
    }
}
