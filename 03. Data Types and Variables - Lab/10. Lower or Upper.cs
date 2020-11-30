using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            if (letter.Any(char.IsUpper))
            {
                Console.WriteLine("upper-case");
            }
            else if (letter.Any(char.IsLower))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
