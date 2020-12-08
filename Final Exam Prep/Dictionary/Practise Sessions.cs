using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.April._2019_01.PractiseSessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roads = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split("->");
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string road = tokens[1];
                        string racer = tokens[2];
                        if (!roads.ContainsKey(road))
                        {
                            roads.Add(road, new List<string>());
                            roads[road].Add(racer);
                        }
                        else
                        {
                            roads[road].Add(racer);
                        }
                        break;

                    case "Move":
                        string currentRoad = tokens[1];
                        string racerToMove = tokens[2];
                        string nextRoad = tokens[3];

                        if (roads[currentRoad].Contains(racerToMove))
                        {
                            roads[nextRoad].Add(racerToMove);
                            roads[currentRoad].Remove(racerToMove);
                        }
                        break;

                    case "Close":
                        string toDelete = tokens[1];
                        if (roads.ContainsKey(toDelete))
                        {
                            roads.Remove(toDelete);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Practice sessions:");

            roads = roads.OrderByDescending(x => x.Value.Count)
                         .ThenBy(x => x.Key)
                         .ToDictionary(x => x.Key, y => y.Value);

            foreach (var road in roads)
            {
                Console.WriteLine(road.Key);

                for (int i = 0; i < road.Value.Count; i++)
                {
                    Console.WriteLine($"++{road.Value[i]}");
                }
            }

        }
    }
}
