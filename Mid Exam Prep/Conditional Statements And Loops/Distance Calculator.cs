using System;

namespace _01.DistanceCalculator_30.June._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            decimal stepLength = decimal.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            decimal result = 0;
            decimal shortSteps = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    shortSteps = stepLength - (stepLength * 30 / 100);
                    result += shortSteps;
                }
                else
                {
                    result += stepLength;
                }
            }

            result /= 100;
            decimal percentage = result / distance * 100;
            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
