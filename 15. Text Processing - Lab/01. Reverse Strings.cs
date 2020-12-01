using System;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var reversedString = input.ToArray().Reverse();

                Console.WriteLine($"{input} = {string.Join("", reversedString)}");
            }
        }

    }
}
