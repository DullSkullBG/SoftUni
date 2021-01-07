using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            if (city=="Sofia" && product=="coffee")
            {
                double sum = amount * 0.50;
                Console.WriteLine(sum);
            }
            else if (city == "Sofia" && product == "water")
            {
                double sum = amount * 0.80;
                Console.WriteLine(sum);
            }
            else if (city == "Sofia" && product == "beer")
            {
                double sum = amount * 1.20;
                Console.WriteLine(sum);
            }
            else if (city == "Sofia" && product == "sweets")
            {
                double sum = amount * 1.45;
                Console.WriteLine(sum);
            }
            else if (city == "Sofia" && product == "peanuts")
            {
                double sum = amount * 1.60;
                Console.WriteLine(sum);
            }
            if (city == "Plovdiv" && product == "coffee")
            {
                double sum = amount * 0.40;
                Console.WriteLine(sum);
            }
            else if (city == "Plovdiv" && product == "water")
            {
                double sum = amount * 0.70;
                Console.WriteLine(sum);
            }
            else if (city == "Plovdiv" && product == "beer")
            {
                double sum = amount * 1.15;
                Console.WriteLine(sum);
            }
            else if (city == "Plovdiv" && product == "sweets")
            {
                double sum = amount * 1.30;
                Console.WriteLine(sum);
            }
            else if (city == "Plovdiv" && product == "peanuts")
            {
                double sum = amount * 1.50;
                Console.WriteLine(sum);
            }
            if (city == "Varna" && product == "coffee")
            {
                double sum = amount * 0.45;
                Console.WriteLine(sum);
            }
            else if (city == "Varna" && product == "water")
            {
                double sum = amount * 0.70;
                Console.WriteLine(sum);
            }
            else if (city == "Varna" && product == "beer")
            {
                double sum = amount * 1.10;
                Console.WriteLine(sum);
            }
            else if (city == "Varna" && product == "sweets")
            {
                double sum = amount * 1.35;
                Console.WriteLine(sum);
            }
            else if (city == "Varna" && product == "peanuts")
            {
                double sum = amount * 1.55;
                Console.WriteLine(sum);
            }
        }
    }
}
