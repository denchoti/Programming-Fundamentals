using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Last note")
            {
                string pattern = @"^(?<name>[A-z0-9!@#$?]+)=(\d+)<<(.*)";
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int length = int.Parse(match.Groups[1].Value);
                    string coordinates = match.Groups[2].Value;

                    if (length == coordinates.Length)
                    {
                        StringBuilder result = new StringBuilder();
                        foreach (char item in name)
                        {
                            if (char.IsLetter(item))
                            {
                                result.Append(item);
                            }
                            
                        }
                        Console.WriteLine($"Coordinates found! {result} -> {coordinates}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
                

                input = Console.ReadLine();
            }
        }
    }
}
