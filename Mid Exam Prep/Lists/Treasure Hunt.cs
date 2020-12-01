using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TreasureHunt__6.August._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();

            string input = Console.ReadLine();
            while (input != "Yohoho!")
            {
                List<string> tokens = input.Split().ToList();
                string command = tokens[0];
                int index = int.Parse(tokens[1]);

                if (command == "Loot")
                {
                    string[] items = tokens.Skip(1).ToArray();
                    LootChest(items, chest);
                    string item = tokens[1];
                    if (chest.Contains(item))
                    {
                        chest.Insert(0, item);
                    }
                }
                else if (command == "Drop")
                {
                    string item = chest[index];
                    if (index >= 0 && index< chest.Count)
                    {
                        chest.RemoveAt(index);
                        chest.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", chest));
        }

      

        public static void LootChest(string[] items, List<string> chest)
        {
            foreach (string  item in items)
            {
                if (!chest.Contains(item))
                {
                    chest.Insert(0, item);
                }
            }
        }
    }
}
