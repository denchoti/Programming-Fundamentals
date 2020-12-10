using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=\/])(?<name>[A-Z][A-Za-z]{2,})\1";

            List<string> places = new List<string>();
            int points = 0;

            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    int length = name.Length;
                    points += length;
                    places.Add(name);
                }
            }

            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
