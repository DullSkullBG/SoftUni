using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int temp = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (temp>=10 && temp<=18)
            {
                if (day== "Morning")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Sweatshirt and Sneakers."); 
                }
                else if (day== "Afternoon")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                }
                else if (day== "Evening")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (temp>18 && temp<=24)
            {
                if (day == "Morning")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                }
                else if (day == "Afternoon")
                {
                    Console.WriteLine($"It's {temp} degrees, get your T-Shirt and Sandals.");
                }
                else if (day == "Evening")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (temp>=25)
            {
                if (day == "Morning")
                {
                    Console.WriteLine($"It's {temp} degrees, get your T-Shirt and Sandals.");
                }
                else if (day == "Afternoon")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Swim Suit and Barefoot.");
                }
                else if (day == "Evening")
                {
                    Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
