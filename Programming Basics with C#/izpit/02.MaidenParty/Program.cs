using System;

namespace _02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double womenParty = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int cartoons = int.Parse(Console.ReadLine());
            int luckSurprise = int.Parse(Console.ReadLine());
            double sum = loveMessages * 0.60 + waxRoses * 7.20 + keychains * 3.60 + cartoons * 18.20 + luckSurprise * 22;
            double NumberOfItems = loveMessages + waxRoses + keychains + cartoons + luckSurprise;
            if (NumberOfItems>=25)
            {
                double a = sum * 0.35;
                 sum -= a;
             
            }

            double host = sum * 0.10;
            double all = sum - host;
            if (all > womenParty)
            {
                double rest = all - womenParty;
                Console.WriteLine($"Yes! {rest:f2} lv left.");
            }
            else
            {
                double rest =  womenParty-all;
                Console.WriteLine($"Not enough money! {rest:f2} lv needed.");
            }

        }
    }
}
