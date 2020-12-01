using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FroggySquad_30.June._2019_
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> froggies = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (!input.Contains("Print"))
            {
                string[] commands = input.Split();
                string operation = commands[0];

                if (operation == "Join")
                {
                    string name = commands[1];
                    froggies.Add(name);
                }
                else if (operation == "Jump")
                {
                    string name = commands[1];
                    int index = int.Parse(commands[2]);

                    if (index >= 0 && index < froggies.Count)
                    {
                        froggies.Insert(index, name);
                    }
                }

                else if (operation == "Dive")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < froggies.Count)
                    {

                        froggies.Remove(froggies[index]);
                    }
                }

                else if (operation == "First")
                {
                    int count = int.Parse(commands[1]);
                    if (count >= froggies.Count)
                    {
                        Console.WriteLine(string.Join(' ', froggies));
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(froggies[i] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                else if (operation == "Last")
                {
                    int count = int.Parse(commands[1]);
                    if (count >= froggies.Count)
                    {
                        Console.WriteLine(string.Join(' ', froggies));
                    }
                    else
                    {
                        for (int i = froggies.Count - count; i < froggies.Count; i++)
                        {
                            Console.Write(froggies[i] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                input = Console.ReadLine();
            }

            string[] element = input.Split();
            if (element[1] == "Reversed")
            {
                froggies.Reverse();
                Console.Write($"Frogs: {string.Join(' ', froggies)}");
            }
            else
            {
                Console.Write($"Frogs: {string.Join(' ', froggies)}");
            }
        }
    }
}
