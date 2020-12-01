using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int registrations = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"([U$]+)(?<username>[A-Z][a-z]+)\1([P@$]+)(?<password>[A-Za-z]{5,}[0-9]+)\2";

                Match match = Regex.Match(input, pattern);
                

                if (match.Success)
                {
                    string username = match.Groups["username"].Value;
                    string password = match.Groups["password"].Value;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                    registrations++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {registrations}");
        }
    }
}
