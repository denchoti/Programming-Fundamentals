using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SantaSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input!= "end")
            {
                string pattern = @"@([A-Z][a-z]+)[^@\\\-!:>]*!([G])!";
                string result = "";

                for (int i = 0; i < input.Length; i++)
                {
                    char symbol = (char)(input[i] - key);
                    result += symbol;
                }
                result = result.ToString();

                Match match = Regex.Match(result, pattern);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }
        }
    }
}

