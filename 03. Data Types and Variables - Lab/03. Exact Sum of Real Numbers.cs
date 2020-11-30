using System;

namespace _3.ExactSumRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal current = decimal.Parse(Console.ReadLine());
                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}
