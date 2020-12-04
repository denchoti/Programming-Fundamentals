using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string barcode = match.Groups[1].Value;
                    StringBuilder result = new StringBuilder();
                    for (int j = 0; j < barcode.Length; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            result.Append(barcode[j]);
                        }
                      
                      
                    }
                    if(String.IsNullOrEmpty(result.ToString()))
                    {
                        result.Append("00");
                    }
                    Console.WriteLine($"Product group: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
