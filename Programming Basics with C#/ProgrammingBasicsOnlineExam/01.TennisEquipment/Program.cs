using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int timePhoto = int.Parse(Console.ReadLine());
            int scene = int.Parse(Console.ReadLine());
            int timeScene = int.Parse(Console.ReadLine());
            double count1 = timePhoto * 0.15;
            double count2 = scene * timeScene;
            double time = count1 + count2;
            if (timePhoto>time)
            {
                double count3 = timePhoto - time;
                int da = (int)count3;
                Console.WriteLine($"You managed to finish the movie on time! You have {da} minutes left!");
            }
            else
            {
                double count4 = time - timePhoto;
                int ne = (int)count4;
                Console.WriteLine($"Time is up! To complete the movie you need {ne} minutes.");
            }
        }
    }
}
