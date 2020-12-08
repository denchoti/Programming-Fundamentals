using System;
using System.Linq;

namespace WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "For Azeroth")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "GladiatorStance":
                        skill = skill.ToUpper();
                        Console.WriteLine(skill);
                        break;

                    case "DefensiveStance":
                        skill = skill.ToLower();
                        Console.WriteLine(skill);
                        break;

                    case "Dispel":
                        int index = int.Parse(tokens[1]);
                        char letter = char.Parse(tokens[2]);
                        if (index >= 0 && index < skill.Length)
                        {
                            
                           skill =  skill.Replace(skill[index], letter);
                            Console.WriteLine("Success!");
                        }
                        else
                        {
                            Console.WriteLine("Dispel too weak.");
                        }
                        break;

                    case "Target":
                        string substring = tokens[2];
                        if (tokens[1] == "Change")
                        {
                            string second = tokens[3];
                            if (skill.Contains(substring))
                            {
                                skill = skill.Replace(substring, second);
                                Console.WriteLine(skill);
                            }

                        }
                        else if (tokens[1] == "Remove")
                        {
                            if (skill.Contains(substring))
                            {
                                int start = skill.IndexOf(substring);
                                skill = skill.Remove(start, substring.Length);
                                Console.WriteLine(skill);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
