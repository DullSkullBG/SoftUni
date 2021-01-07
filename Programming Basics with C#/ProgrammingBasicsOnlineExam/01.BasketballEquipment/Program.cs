using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearFee = int.Parse(Console.ReadLine());
            double count = yearFee * 0.40;
            double shoes = yearFee - count;
            double count2 = shoes * 0.20;
            double tshirt = shoes - count2;
            double ball = tshirt / 4;
            double count3 = ball / 5;
            double sum = yearFee + shoes + tshirt + ball + count3;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
