using System;

namespace _04.PrintingTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumbersFromOne(i);
            }
            for (int i = n-1; i > 0; i--)
            {
                PrintNumbersFromOne(i);
            }
        }
        static void PrintNumbersFromOne (int to)
        {
            for (int i = 1; i <= to; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
