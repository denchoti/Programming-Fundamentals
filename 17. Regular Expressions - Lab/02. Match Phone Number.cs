using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MathPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            var numbers = Console.ReadLine();

            var matches = Regex.Matches(numbers, pattern);

            var matchedNumbers = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedNumbers));
        }
    }
}
