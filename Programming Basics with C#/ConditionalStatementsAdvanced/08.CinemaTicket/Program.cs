using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Friday":
                case "Tuesday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;     
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
                default:
                    break;
            }
        }
    }
}
