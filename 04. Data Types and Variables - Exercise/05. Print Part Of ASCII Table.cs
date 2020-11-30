using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.Write((char)i + " ");
            }
            
        }
    }
}
