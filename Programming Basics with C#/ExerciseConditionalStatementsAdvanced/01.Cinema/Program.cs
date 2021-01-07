using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (ticket== "Premiere")
            {
                double result = r * c * 12;
                Console.WriteLine($"{result:f2} leva");
            }
            else if (ticket== "Normal")
            {
                double result = r * c * 7.50;
                Console.WriteLine($"{result:f2} leva");
            }
            else if (ticket== "Discount")
            {
                double result = r * c * 5;
                Console.WriteLine($"{result:f2} leva");
            }
        }
    }
}
