using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Case":
                        string cases = tokens[1];
                        if (cases == "lower")
                        {
                            username = username.ToLower();
                            Console.WriteLine(username);
                        }
                        else if (cases == "upper")
                        {
                            username = username.ToUpper();
                            Console.WriteLine(username);
                        }
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        if ((startIndex < username.Length && startIndex >=0) &&
                            endIndex < username.Length && endIndex >= 0)
                        {
                            string reversed = username.Substring(startIndex, (endIndex - startIndex) + 1);
                            Console.WriteLine(string.Join("",reversed.Reverse()));
                        }
                        break;

                    case "Cut":
                        string substring = tokens[1];
                        if (username.Contains(substring))
                        {
                            username = username.Remove(username.IndexOf(substring), substring.Length);
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The word {username} doesn't contain {substring}.");
                        }
                        break;

                    case "Replace":
                        char toReplace = char.Parse(tokens[1]);
                        username = username.Replace(toReplace, '*');
                        Console.WriteLine(username);
                        break;

                    case "Check":
                        char toCheck = char.Parse(tokens[1]);
                        if (username.Contains(toCheck))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {toCheck}.");
                        }
                        break;

                }

                input = Console.ReadLine();
            }
        }
    }
}
