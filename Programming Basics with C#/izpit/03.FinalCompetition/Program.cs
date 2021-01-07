using System;

namespace _03.FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfDancers = int.Parse(Console.ReadLine());
            double NumberOfPoints = double.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            string Place = Console.ReadLine();
            if (Place== "Bulgaria")
            {
                double result = NumberOfDancers * NumberOfPoints;
                if (Season== "summer")
                {
                    double procent = result * 0.05;
                    result -= procent;
                }
                else
                {
                    double procent = result * 0.08;
                    result -= procent;
                }
                double procent3 = result * 0.75;
                double all = result - procent3;
                double finaly = all / NumberOfDancers;
                Console.WriteLine($"Charity - {procent3:f2}");
                Console.WriteLine($"Money per dancer - {finaly:f2}");
            }
            else
            {
                double sum = NumberOfDancers * NumberOfPoints;
                double procent =sum / 2;
                double result = sum + procent;
                if (Season == "summer")
                {
                    double procent2 = result * 0.10;
                    result -= procent2;
                }
                else
                {
                    double procent2 = result * 0.15;
                     result -= procent2;
                    
                }
                double procent3 = result * 0.75;
                double all = result - procent3;
                double finaly = all / NumberOfDancers;
                Console.WriteLine($"Charity - {procent3:f2}");
                Console.WriteLine($"Money per dancer - {finaly:f2}");
            }
        }
    }
}
