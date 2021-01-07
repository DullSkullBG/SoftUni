using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            if (day== "Monday" || day== "Friday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday")
            {
              
                 if (fruit== "banana")
                {
                    double sum = 2.50 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit== "apple")
                {
                    double sum = 1.20 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    double sum = 0.85 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double sum = 1.45 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double sum = 2.70 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double sum = 5.50 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    double sum = 3.85 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
            }
            else if (day== "Saturday" || day== "Sunday")
            {
               
                if (fruit == "banana")
                {
                    double sum = 2.70 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    double sum = 1.25 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    double sum = 0.90 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double sum = 1.60 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double sum = 3.00 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double sum = 5.60 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    double sum = 4.20 * amount;
                    Console.WriteLine($"{sum:f2}");
                }
            }
            
        }
    }
}
