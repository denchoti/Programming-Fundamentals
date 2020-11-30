using System;

namespace _06.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateRectangleArea
                (int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())));
        }
        static int CalculateRectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
