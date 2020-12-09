using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);   
            List<string> mirroredWords = new List<string>();

            foreach (Match match in matches)
            {

                string first = match.Groups["first"].Value;
                string reversed = String.Concat(first.Reverse());
                string second = match.Groups["second"].Value;

                if (reversed == second)
                {
                    mirroredWords.Add($"{first} <=> {second}"); 
                }

            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (mirroredWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are: ");
                Console.Write($"{string.Join(", ", mirroredWords)}");

            }
        }
    }
}
