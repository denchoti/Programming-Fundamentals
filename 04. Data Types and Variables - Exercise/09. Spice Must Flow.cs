using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger startingYeld = BigInteger.Parse(Console.ReadLine());

            BigInteger produced = 0;
            BigInteger days = 0;

            if (startingYeld < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(produced);
            }
            else
            {
                while (startingYeld >= 100)
                {
                    produced += startingYeld - 26;
                    startingYeld -= 10;
                    days++;
                }

                produced -= 26;

                Console.WriteLine(days);
                Console.WriteLine(produced);
            }

        }
    }
}
