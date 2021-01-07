using System;

namespace _04.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double procent1;
            double procent2;
            double procent3;
            double procent4;
            double average = 0;
            for (int i = 0; i < people; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade>=5.00)
                {
                    group1++;
                   
                }
                else if (grade>=4 && grade<=4.99)
                {
                    group2++;
                }
                else if (grade>=3 && grade<=3.99)
                {
                    group3++;

                }
                else if (grade<3)
                {
                    group4++;
                }
                average += grade;
            }
            procent1 = group1 / people * 100;
            Console.WriteLine($"Top students: {procent1:f2}%");
            procent2 = group2 / people * 100;
            Console.WriteLine($"Between 4.00 and 4.99: {procent2:f2}%");
            procent3 = group3 / people * 100;
            Console.WriteLine($"Between 3.00 and 3.99: {procent3:f2}%");
            procent4 = group4 / people * 100;
            Console.WriteLine($"Fail: {procent4:f2}%");
            average /= people;
            Console.WriteLine($"Average: {average:f2}");


        }
    }
}
