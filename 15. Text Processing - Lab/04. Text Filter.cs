using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                text = text.Replace(input[i], new String('*', input[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
