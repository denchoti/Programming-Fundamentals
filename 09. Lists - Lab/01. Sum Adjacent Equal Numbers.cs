using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();

            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(double.Parse(list[i]));
            }

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
