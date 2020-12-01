using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.August._2019_01.BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> players = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "Results")
            {
                string[] tokens = input.Split(":");
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string person = tokens[1];
                        int health = int.Parse(tokens[2]);
                        int energy = int.Parse(tokens[3]);

                        if (!players.ContainsKey(person))
                        {
                            players.Add(person, new List<int>());
                            players[person].Add(0);
                            players[person].Add(0);
                            players[person][1] += energy;
                        }
                        players[person][0] += health;
                        break;

                    case "Attack":
                        string attacker = tokens[1];
                        string defender = tokens[2];
                        int damage = int.Parse(tokens[3]);

                        if (players.ContainsKey(attacker) && players.ContainsKey(defender))
                        {
                            players[defender][0] -= damage;
                            if (players[defender][0] < 1)
                            {
                                Console.WriteLine($"{defender} was disqualified!");
                                players.Remove(defender);
                            }
                            players[attacker][1]--;
                            if (players[attacker][1] < 1)
                            {
                                Console.WriteLine($"{attacker} was disqualified!");
                                players.Remove(attacker);
                            }
                        }
                        break;

                    case "Delete":
                        string toDelete = tokens[1];
                        if (toDelete == "All")
                        {
                            players.Clear();
                        }
                        else if (players.ContainsKey(toDelete))
                        {
                            players.Remove(toDelete);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"People count: {players.Keys.Count}");
            players = players.OrderByDescending(x => x.Value[0])
                             .ThenBy(x => x.Key)
                             .ToDictionary(x => x.Key, y => y.Value);

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key} - {player.Value[0]} - {player.Value[1]}");
            }
        }
    }
}
