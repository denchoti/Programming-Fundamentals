using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory_29.February._2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string item = tokens[1];

                if (command == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }

                else if (command == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }

                else if (command == "Combine Items")
                {
                    string[] items = item.Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];

                    int index = inventory.IndexOf(oldItem);
                    if (inventory.Contains(oldItem))
                    {
                        inventory.Insert(index + 1, newItem);
                    }
                   
                }

                else if (command == "Renew")
                {
                    
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
  
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
