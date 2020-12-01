using System;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            long stepsMade = long.Parse(Console.ReadLine());
            decimal lengthOfStep = decimal.Parse(Console.ReadLine());
            long distance = long.Parse(Console.ReadLine());
            decimal result = 0;
            decimal shortStep = 0;

            for (int i = 0; i < stepsMade; i++)  // for (int i = 1; i <= stepsMade; i++)
            {
                if (i % 5 == 0)
                {
                    shortStep = lengthOfStep * 0.70m;
                    result += shortStep;
                }
                else
                {
                    result += lengthOfStep;
                }
            }

            result /= 100;
            decimal diff = result / distance * 100m;
            Console.WriteLine($"You travelled {diff:f2}% of the distance!");
        }
    }
}
