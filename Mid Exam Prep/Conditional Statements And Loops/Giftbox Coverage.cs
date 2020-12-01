using System;

namespace _01.GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            int paperCount = int.Parse(Console.ReadLine());
            double sheetCoverage = double.Parse(Console.ReadLine());

            double totalArea = side * side * 6;
            double coverage = 0;
            double thirdSheet = 0;
            for (int i = 1; i <= paperCount; i++)
            {
                if (i % 3 == 0)
                {
                    thirdSheet = sheetCoverage * 25 / 100; // covers only 25% of the usual area
                    coverage += thirdSheet;
                }
                else
                {
                    coverage += sheetCoverage;
                }
            }

            double percentage = coverage / totalArea * 100;
            Console.WriteLine($"You can cover {percentage:f2}% of the box.");
        }
    }
}
