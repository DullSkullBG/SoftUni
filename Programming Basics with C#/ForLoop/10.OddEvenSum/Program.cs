using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 1; i <= a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    even += b;
                }
                else
                {
                    odd += b;
                }
            }
            if (even==odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = { Math.Abs(even - odd)}");
            }
        }
    }
}
