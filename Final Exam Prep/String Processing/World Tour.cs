using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] tokens = input.Split(":");
                string command = tokens[0];

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string insert = tokens[2];
                        if (index >= 0 && index < destinations.Length)
                        {
                            destinations = destinations.Insert(index, insert);
                        }
                        Console.WriteLine(destinations);
                        break;

                    case "Remove Stop":
                        int start = int.Parse(tokens[1]);
                        int end = int.Parse(tokens[2]);

                        if ((start >= 0 && start < destinations.Length) && (end >= 0 && end < destinations.Length))
                        {
                            destinations = destinations.Remove(start, end - start +1);   
                        }
                        Console.WriteLine(destinations);
                        break;

                    case "Switch":
                        string old = tokens[1];
                        string replacement = tokens[2];
                        if (destinations.Contains(old))
                        {
                            destinations = destinations.Replace(old, replacement);
                        }
                        Console.WriteLine(destinations);
                        break;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
