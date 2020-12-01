using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.August._2019_01.MessageManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();

            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] tokens = input.Split("=");
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string name = tokens[1];
                        int sent = int.Parse(tokens[2]);
                        int received = int.Parse(tokens[3]);

                        if (!users.ContainsKey(name))
                        {
                            users.Add(name, new List<int>());
                            users[name].Add(0);
                            users[name].Add(0);

                            users[name][0] += sent;
                            users[name][1] += received;
                        }
                        break;

                    case "Message":
                        string sender = tokens[1];
                        string receiver = tokens[2];
                        if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                        {
                            users[sender][0] ++;
                            users[receiver][1] ++;

                            int maxSender = users[sender][0] + users[sender][1];
                            int maxReceiver = users[receiver][0] + users[receiver][1];

                            if (maxSender >= capacity)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                users.Remove(sender);
                            }
                            if (maxReceiver >= capacity)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                users.Remove(receiver);
                            }
                        }
                        break;

                    case "Empty":
                        string toDelete = tokens[1];
                        if (toDelete == "All")
                        {
                            users.Clear();
                        }
                        else
                        {
                            users.Remove(toDelete);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            users = users
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var name in users)
            {
                int sum = name.Value[0] + name.Value[1];
                Console.WriteLine($"{name.Key} - {sum}");
            }
        }
    }
}
