﻿using System;

namespace _10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number == 0)
            {

            }
            else if (number<100 )
            {
                Console.WriteLine("invalid");
            }
            else if (number>200)
            {
                Console.WriteLine("invalid");
            }
          
           

        }
    }
}
