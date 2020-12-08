using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.December._2019_InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] tokens = input.Split("->");
                string command = tokens[0];
                string username = tokens[1];

                switch (command)
                {
                    case "Add":
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{username} is already registered");
                        }
                        break;

                    case "Send":
                        string email = tokens[2];
                        users[username].Add(email);
                        break;

                    case "Delete":
                        if (users.ContainsKey(username))
                        {
                            users.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} not found!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            users = users.OrderByDescending(x => x.Value.Count)
                         .ThenBy(x => x.Key)
                         .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in users)
            {
                Console.WriteLine(user.Key);

                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($"- {user.Value[i]}");
                }
                
            }

        }
    }
}
