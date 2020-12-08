using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.August._2019_01.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] cmdArgs = input.Split(": ");
                string command = cmdArgs[0];
                string username = cmdArgs[1];

                switch (command)
                {
                    case "New follower":
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new List<int>());
                            users[username].Add(0);
                            users[username].Add(0);
                        }
                        break;

                    case "Like":
                        int count = int.Parse(cmdArgs[2]);
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new List<int>());
                            users[username].Add(0);
                            users[username].Add(0);
                        }
                        users[username][0] += count;
                        break;

                    case "Comment":
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new List<int>());
                            users[username].Add(0);
                            users[username].Add(0);
                        }
                        users[username][1] += 1;
                        break;

                    case "Blocked":
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        else
                        {
                            users.Remove(username);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{users.Count} followers");

            users = users
                .OrderByDescending(x => x.Value[0]) //sorted first by the likes -> [0]
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var user in users)
            {
                int sum = user.Value[0] + user.Value[1];
                Console.WriteLine($"{user.Key}: {sum}");
            }


        }
    }
}
