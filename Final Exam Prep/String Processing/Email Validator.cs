using System;
using System.Linq;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Make":
                        if (tokens[1] == "Upper")
                        {
                            text = text.ToUpper();
                            Console.WriteLine(text);
                        }
                        else if (tokens[1] == "Lower")
                        {
                            text = text.ToLower();
                            Console.WriteLine(text);
                        }
                        break;

                    case "GetDomain":
                        int count = int.Parse(tokens[1]);
                        if (count >= 0 && count < text.Length)
                        {
                            Console.WriteLine($"{text.Substring(text.Length - count)}");
                        }
                        else
                        {
                            Console.WriteLine(text);
                        }
                        break;

                    case "GetUsername":
                        if (text.Contains('@'))
                        {
                            Console.WriteLine(text.Substring(0, text.IndexOf('@')));
                        }
                        break;

                    case "Replace":
                        char toReplace = char.Parse(tokens[1]);
                        text = text.Replace(toReplace, '-');
                        Console.WriteLine(text);
                        break;

                    case "Encrypt":
                        foreach (var letter in text)
                        {
                            Console.Write((int)letter + " ");
                        }
                        Console.WriteLine();
                        break;
                }
                input = Console.ReadLine();
            }

        }
    }
}
