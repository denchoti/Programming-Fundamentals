using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            BigInteger highestValue = int.MinValue;
            short highestSnow = 0;
            short highestTime = 0;
            short highestQuality = 0;
         
            for (int i = 0; i < n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
               
                if (highestValue < snowballValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}
