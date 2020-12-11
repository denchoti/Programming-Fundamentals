using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([|#])(?<name>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(input, pattern);
            int sum = 0;
            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                sum += calories;
            }

            int days = sum / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                string calories = match.Groups["calories"].Value;
                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
