using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"(.*)>(?<first>[0-9]{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^<>]{3})<\1";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string first = match.Groups["first"].Value;
                    string second = match.Groups["second"].Value;
                    string third = match.Groups["third"].Value;
                    string fourth = match.Groups["fourth"].Value;

                    string password = String.Concat(first, second, third, fourth);
                    Console.WriteLine($"Password: {password}");

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
