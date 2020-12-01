using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encrypted = String.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                encrypted += (char)(text[i] + 3);
            }
            Console.WriteLine(encrypted);
        }
    }
}
