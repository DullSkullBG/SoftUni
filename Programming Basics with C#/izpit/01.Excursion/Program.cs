using System;
namespace _01.Excursion
{

    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());
            int a = nights * 20;
            double b = transportCards * 1.60;
            int c = museumTickets * 6;
            double sum = a + b + c;
            double sumAll = sum * people;
            double procent = sumAll * 0.25;
            double all = sumAll + procent;
            Console.WriteLine($"{all:f2}");
        }
    }
}
