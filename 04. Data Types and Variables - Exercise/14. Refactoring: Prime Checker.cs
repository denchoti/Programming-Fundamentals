using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Threading;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                bool isPrime = true;
                
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {(isPrime.ToString().ToLower())}");
            }

        }
    }
}
