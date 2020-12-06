using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] cmdArgs = input.Split("||");
                string name = cmdArgs[0];
                int people = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                if (!towns.ContainsKey(name))
                {
                    towns.Add(name, new List<int>());
                    towns[name].Add(people);
                    towns[name].Add(gold);

                }
                else
                {
                    towns[name][0] += people;
                    towns[name][1] += gold;
                }

                input = Console.ReadLine();
            }
            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] tokens = commands.Split("=>");
                string command = tokens[0];
                string town = tokens[1];

                switch (command)
                {
                    case "Plunder":
                        int people = int.Parse(tokens[2]);
                        int gold = int.Parse(tokens[3]);
                        towns[town][0] -= people;
                        towns[town][1] -= gold;


                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (towns[town][0] <= 0 || towns[town][1] <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            towns.Remove(town);
                        }
                        break;

                    case "Prosper":
                        int goldAdd = int.Parse(tokens[2]);
                        if (goldAdd <= 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            towns[town][1] += goldAdd;
                            int total = towns[town][1];
                            Console.WriteLine($"{goldAdd} gold added to the city treasury. {town} now has {total} gold.");
                        }
                        break;
                }

                commands = Console.ReadLine();
            }
            towns = towns.OrderByDescending(x => x.Value[1])
                         .ThenBy(x => x.Key)
                         .ToDictionary(x => x.Key, y => y.Value);
            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var town in towns)
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
