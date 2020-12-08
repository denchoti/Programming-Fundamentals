using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.December._2019_NikuldensMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            int unliked = 0;
            while (input != "Stop")
            {
                string[] tokens = input.Split("-");
                string command = tokens[0];
                string guest = tokens[1];
                string meal = tokens[2];

                switch (command)
                {
                    case "Like":
                        if (!guests.ContainsKey(guest))
                        {
                            guests.Add(guest, new List<string>());
                        }
                        if (!guest.Contains(meal))
                        {
                            guests[guest].Add(meal);
                        }
                        break;

                    case "Unlike":
                        if (!guests.ContainsKey(guest))
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        else if (!guests[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            guests[guest].Remove(meal);
                            unliked++;
                        }        
                        break;
                }
                input = Console.ReadLine();
            }

            guests = guests.OrderByDescending(x => x.Value.Count)
                           .ThenBy(x => x.Key)
                           .ToDictionary(x => x.Key, y => y.Value);


            foreach (var (guest,meal) in guests)
            {
                Console.WriteLine($"{guest}: {string.Join(", ", meal)}");
            }

            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }
}
