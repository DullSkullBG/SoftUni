using System;

namespace _05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            int metre = 5364;
            int day = 1;
            
            
            while (text!= "END" )
            {
                
                int sum = int.Parse(Console.ReadLine());

                if (text=="Yes")
                {
                    day++;
                }
                
                if (day>5)
                {
                    break;
                }
                metre += sum;
                if (metre>=8848)
                {
                    break;
                }
                text = Console.ReadLine();
            }
            if (metre>=8848)
            {
                Console.WriteLine($"Goal reached for {day} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{metre}");
            }
          
        }
    }
}
