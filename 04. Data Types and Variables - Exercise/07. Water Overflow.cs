using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int capacity = 255;
            int totalLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                
                if (totalLiters + liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLiters += liters;
                }
               
            }
            Console.WriteLine(totalLiters);
        }
    }
}
