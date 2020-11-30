using System;
using System.Security.Cryptography;

namespace BasicSyntaxDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }

        }
    }
}
