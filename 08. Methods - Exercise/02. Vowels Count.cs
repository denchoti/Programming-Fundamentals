using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            CountVowels(text);
        }
        static void CountVowels(string text)
        {
            int vowelCounter = 0;
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    vowelCounter++;
                }
            }
            Console.WriteLine(vowelCounter);
        }
    }
}
