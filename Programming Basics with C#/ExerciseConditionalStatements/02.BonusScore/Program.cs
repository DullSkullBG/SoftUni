using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double a,a1;
           
            if (number > 1000)
            {
                if (number%2==0)
                {
                    if (number % 10 == 5)
                    {
                        a = (number * 0.10) + 3;
                        a1 = a + number;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    else
                    {
                        a = (number * 0.10) + 1;
                        a1 = a + number;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    
                }
                else
                {
                    if (number % 10 == 5)
                    {
                        a = (number * 0.10)+2;
                        a1 = a + number;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    else
                    {
                        a = number * 0.10;
                        a1 = a + number;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    
                }
               
                
                
            }
            else if (number > 100)
            {
                if (number % 2 == 0)
                {
                    if (number % 10 == 5)
                    {
                        a = (number * 0.20) + 3;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    else
                    {
                        a = (number * 0.20) + 1;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    
                }

                else
                {
                    if (number % 10 == 5)
                    {
                        a = (number * 0.20)+2;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    else
                    {
                        a = number * 0.20;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    
                }
                
            }
            else  if (number<=100)
            {
                if (number % 2 == 0)
                {
                    if (number % 10 == 5)
                    {
                        a = 8;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    else
                    {
                        a = 6;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                   
                }
                else
                {
                    if (number % 10 == 5)
                    {
                        a = 7;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                    else
                    {
                        a = 5;
                        a1 = number + a;
                        Console.WriteLine(a);
                        Console.WriteLine(a1);
                    }
                   
                }
               
            }
            


        }
    }
}
