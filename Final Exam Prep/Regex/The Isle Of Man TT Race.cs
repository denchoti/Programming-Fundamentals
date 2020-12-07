using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TheIsleOfManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                string input = Console.ReadLine();
                string pattern = $@"([#$%*&])(?<names>[a-zA-Z]+)\1=(\d+)!!(.*)$";

                Match correct = Regex.Match(input, pattern);

                if (correct.Success)
                {
                    string name = correct.Groups["names"].Value;
                    int length = int.Parse(correct.Groups[2].Value);
                    string coordinates = correct.Groups[3].Value;

                    if (length == coordinates.Length)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < coordinates.Length; i++)
                        {
                            sb.Append((char)(coordinates[i] + length));
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {sb}");
                        break;
                    }
                }
                Console.WriteLine("Nothing found!");
            }

        }
    }
}

