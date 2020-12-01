using System;

namespace _01.BlackFlag__6.August._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    
                    totalPlunder += dailyPlunder * 0.5; // 50/100
                }
                if (i % 5 == 0)
                {
                    totalPlunder *= 0.70; // = totalPlunder - (totalPlunder * 30/100); 
                }
                
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / expectedPlunder  * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
