using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();

            string input = Console.ReadLine();

            var pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[\d]+\.?\d*)!(?<quantity>[\d]+)";
            double totalPrice = 0;
            while (input != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    furniture.Add(match.Groups["name"].Value);
                    totalPrice += double.Parse(match.Groups["price"].Value) 
                                * double.Parse(match.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (totalPrice > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
