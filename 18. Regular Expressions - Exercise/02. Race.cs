using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _05.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namesKm = new Dictionary<string, int>();

            string[] contestants = Console.ReadLine()
                                  .Split(new char[] {' ', ','}
                                  ,StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string digitsPattern = @"\d";

                var nameMatch = Regex.Matches(input, namePattern);
                var kmMatch = Regex.Matches(input, digitsPattern);

                var name = String.Concat(nameMatch);
                var sum = kmMatch.Select(x => int.Parse(x.Value)).Sum();

                if (contestants.Contains(name))
                {
                    if(namesKm.ContainsKey(name))
                    {
                        namesKm[name] += sum;
                    }
                    else
                    {
                        namesKm.Add(name, sum);
                    }
                }

                input = Console.ReadLine();
            }


            var sorted = namesKm.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
