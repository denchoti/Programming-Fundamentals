using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintASCIIChars(start, end);
        }

        static void PrintASCIIChars(char one, char two)
        {
            if (one < two)
            {
                for (int i = one + 1; i < two; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = two + 1; i < one; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            
        }
    }
}
