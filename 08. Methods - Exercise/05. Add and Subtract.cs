using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Subtract(first, second, third);

        }
        static int Sum(int first,int second)
        {
            int sum = first + second;
            return sum;
        }
        static void Subtract(int first,int second,int third)
        {

            Sum(first, second);
            int result = (first + second) - third;
            Console.WriteLine(result);
        }
    }
}
