using System;
using System.Runtime.ExceptionServices;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = FindSmallestNumber(first, second, third);
            Console.WriteLine(min);
        }
        static int FindSmallestNumber(int a,int b, int c)
        {
            return Math.Min(Math.Min(a,b),c);
        }
    }
}
