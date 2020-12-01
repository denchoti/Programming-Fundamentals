using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList_29.February._2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string item = tokens[1];

                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string oldItem = tokens[1];
                    string newitem = tokens[2];
                    if (groceries.Contains(oldItem))
                    {
                        groceries[groceries.IndexOf(oldItem)] = newitem;
                    }

                }
                else if (command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);

                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
