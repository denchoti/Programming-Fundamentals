using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string name = tokens[0];
                int HP = int.Parse(tokens[1]);
                int MP = int.Parse(tokens[2]);

                heroes.Add(name, new List<int>());

                if (HP > 100)
                {
                    HP = 100;
                }
                if (MP > 200)
                {
                    MP = 200;
                }
                heroes[name].Add(HP);
                heroes[name].Add(MP);
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] cmdArgs = commands.Split(" - ");
                string command = cmdArgs[0];
                string hero = cmdArgs[1];

                switch (command)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(cmdArgs[2]);
                        string spell = cmdArgs[3];
                        if (heroes[hero][1] >= mpNeeded)
                        {
                            heroes[hero][1] -= mpNeeded;
                            int manaLeft = heroes[hero][1];
                            Console.WriteLine($"{hero} has successfully cast {spell} and now has {manaLeft} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} does not have enough MP to cast {spell}!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(cmdArgs[2]);
                        string attacker = cmdArgs[3];
                        heroes[hero][0] -= damage;
                        int hpLeft = heroes[hero][0];

                        if (heroes[hero][0] > 0)
                        {
                            Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {hpLeft} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} has been killed by {attacker}!");
                            heroes.Remove(hero);
                        }
                        break;

                    case "Recharge":
                        int amount = int.Parse(cmdArgs[2]);
                        if ((heroes[hero][1] + amount) > 200)
                        {
                            amount = 200 - heroes[hero][1];
                            heroes[hero][1] = 200;
                        }
                        else
                        {
                            heroes[hero][1] += amount;
                        }
                        Console.WriteLine($"{hero} recharged for {amount} MP!");
                        break;

                    case "Heal":
                        int heal = int.Parse(cmdArgs[2]);
                        if ((heroes[hero][0] + heal) > 100)
                        {
                            heal = 100 - heroes[hero][0];
                            heroes[hero][0] = 100;
                        }
                        else
                        {
                            heroes[hero][0] += heal;
                        }
                        Console.WriteLine($"{hero} healed for {heal} HP!");
                        break;
                }
                
                commands = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(x => x.Value[0])
                           .ThenBy(x => x.Key)
                           .ToDictionary(x => x.Key, y => y.Value);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value[0]}");
                Console.WriteLine($"MP: {hero.Value[1]}");
            }
        }
    }
}
