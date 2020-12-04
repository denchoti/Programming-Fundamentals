using System;
using System.Linq;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] tokens = input.Split(">>>");
                string command = tokens[0];

                switch (command)
                {
                    case "Contains":
                        string substring = tokens[1];
                        if (key.Contains(substring))
                        {
                            Console.WriteLine($"{key} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        string caps = tokens[1];
                        int start = int.Parse(tokens[2]);
                        int end = int.Parse(tokens[3]);
                        if (caps == "Upper")
                        {
                            string capsOn = key.Substring(start, end - start);
                            key = key.Remove(start, end - start);
                            capsOn = capsOn.ToUpper();
                            key = key.Insert(start, capsOn);
                            Console.WriteLine(key);

                        }
                        else if (caps == "Lower")
                        {
                            string capsOn = key.Substring(start, end - start);
                            key = key.Remove(start, end - start);
                            capsOn = capsOn.ToLower();
                            key = key.Insert(start, capsOn);
                            Console.WriteLine(key);
                        }
                        break;

                    case "Slice":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        key = key.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(key);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
