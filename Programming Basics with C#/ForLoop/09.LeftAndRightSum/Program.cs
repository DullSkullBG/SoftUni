using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b=n;
            int firstHalf = 0;
            int secondHalf = 0;
            int a;
            for (int i = 0; i < n*2; i++)
            {
                a =int.Parse( Console.ReadLine());
                if (i<b)
                {
                    firstHalf += a;
                }
                else if (i>=b)
                {
                    secondHalf += a;
                }
              
            
            }
            if (firstHalf==secondHalf)
            {
                Console.WriteLine($"Yes, sum = {firstHalf}");
            }
            else if (firstHalf>secondHalf)
            {
                Console.WriteLine($"No, diff = {firstHalf-secondHalf}");
            }
            else if (firstHalf<secondHalf)
            {
                Console.WriteLine($"No, diff = {secondHalf-firstHalf}");
            }

        }
    }
}
