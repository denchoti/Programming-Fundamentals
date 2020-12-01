using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ContactList_30June._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();

            string input = "";
            while (true)
            {
                string[] commands = input.Split().ToArray();
                int index = 0;
                if (commands[0] == "Add")
                {
                    index = int.Parse(commands[2]);
                    if (contacts.Contains(commands[1]))
                    {
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.Insert(index, commands[1]);
                        }
                    }
                    else
                    {
                        contacts.Add(commands[1]);
                    }
                }

                else if (commands[0] == "Remove")
                {
                    index = int.Parse(commands[1]);
                    if (index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }

                else if (commands[0] == "Export")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    List<string> contactsExport = new List<string>();
                    for (int i = startIndex; i <= startIndex + count - 1; i++)
                    {
                        if (i >= contacts.Count)
                        {
                            break;
                        }
                        contactsExport.Add(contacts[i]);
                    }
                    Console.WriteLine(string.Join(" ", contactsExport));
                }

                else if (commands[0] == "Print")
                {
                    if (commands[1] == "Normal")
                    {
                        Console.Write("Contacts: ");
                        Console.Write(string.Join(" ", contacts));
                        break;
                    }
                    else if (commands[1] == "Reversed")
                    {
                        contacts.Reverse();
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contacts));
                        break;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
