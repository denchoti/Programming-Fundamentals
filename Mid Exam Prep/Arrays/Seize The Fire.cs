using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeizeTheFire_10.March._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine().Split("#");

            int water = int.Parse(Console.ReadLine());
            double efforts = 0;
            Console.WriteLine($"Cells:");
            int sum = 0;

            for (int i = 0; i < fires.Length; i++)
            {
                string[] fireArg = fires[i]
                    .Split(" = ");

                string type = fireArg[0];
                int fireValue = int.Parse(fireArg[1]);

                bool isCellValid = IsCellValid(type, fireValue);

                if (isCellValid && water - fireValue >= 0)
                {
                    efforts += fireValue * 0.25;
                    water -= fireValue;
                    Console.WriteLine($" - {fireValue}");
                    sum += fireValue;
                }
            }
              
            Console.WriteLine($"Effort: {efforts:F2}");

            Console.WriteLine($"Total Fire: {sum}");
        }

        private static bool IsCellValid(string type, int fireValue)
        {
            if (type == "High")
            {
                return fireValue >= 81 && fireValue <= 125;
            }
            if (type == "Medium")
            {
                return fireValue >= 51 && fireValue <= 80;
            }
            if (type == "Low")
            {
                return fireValue >= 1 && fireValue <= 50;
            }
            return false;
        }
    }
}
