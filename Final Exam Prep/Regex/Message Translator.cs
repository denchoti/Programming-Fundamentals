using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(!)([A-Z][a-z]{2,})\1:\[([A-Za-z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string first = match.Groups[2].Value;
                    string second = match.Groups[3].Value;

                    Console.Write(first + ":" + " ");

                    foreach (var ch in second)
                    {
                        int final = ch;
                        Console.Write(final + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }

        }
    }
}
