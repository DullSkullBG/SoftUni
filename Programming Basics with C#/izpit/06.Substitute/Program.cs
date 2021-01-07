using System;
 
namespace _06._Substitutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int successful = 0;
            int k = int.Parse(Console.ReadLine()); //1 nomer 1 chislo
            int l = int.Parse(Console.ReadLine()); //1 nomer 2 chislo
            int m = int.Parse(Console.ReadLine()); //2 nomer 1 chislo
            int n = int.Parse(Console.ReadLine()); //2 nomer 2 chislo
 
            // first digit [k, 8] 1 nomer
            // second digit [9; l] 1 nomer
            // second digit [m; 8] 2 nomer
            // second digit [9; n] 2 nomer
            for (int first = k; first <= 8; first++)
            {
                for (int second = 9; second >= l; second--)
                {
                    if (successful >= 6)
                    {
                        break;
                    }
                    if (first % 2 == 0 && second % 2 == 1)
                    {
                        
                        for (int first2 = m; first2 <= 8; first2++)
                        {
                            for (int second2 = 9; second2 >= n; second2--)
                            {
                                if (successful >= 6)
                                {
                                    break;
                                }
                                if (first2 % 2 == 0 && second2 % 2 == 1)
                                {
                                   
                                    if (first != first2 && second!=second2)
                                    {
                                        Console.WriteLine($"{first}{second} - {first2}{second2}");
                                        successful++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}