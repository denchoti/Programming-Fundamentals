using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string name = tokens[1];

                switch (command)
                {
                    case "Enroll":
                        if (!heroes.ContainsKey(name))
                        {
                            heroes.Add(name, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{name} is already enrolled.");
                        }
                        break;

                    case "Learn":
                        string spell = tokens[2];
                        if (heroes.ContainsKey(name))
                        {
                            if (!heroes[name].Contains(spell))
                            {
                                heroes[name].Add(spell);
                            }
                            else
                            {
                                Console.WriteLine($"{name} has already learnt {spell}.");
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                        break;

                    case "Unlearn":
                        string spellName = tokens[2];
                        if (heroes.ContainsKey(name))
                        {
                            if (heroes[name].Contains(spellName))
                            {
                                heroes[name].Remove(spellName);
                            }
                            else
                            {
                                Console.WriteLine($"{name} doesn't know {spellName}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            heroes = heroes.OrderByDescending(x => x.Value.Count)
                           .ThenBy(x => x.Key)
                           .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Heroes: ");
            foreach (var hero in heroes)
            {
                Console.Write($"== {hero.Key}: ");

                for (int i = 0; i < hero.Value.Count; i++)
                {
                    Console.Write($"{hero.Value[i]}, ");
                }
                Console.WriteLine();
            }

        }
    }
}
