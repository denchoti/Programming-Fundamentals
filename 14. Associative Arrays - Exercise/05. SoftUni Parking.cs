using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            Dictionary<string, string> tickets = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputTokens = input.Split();
                string command = inputTokens[0];
                string name = inputTokens[1];

                if (command == "register")
                {
                    string carPlate = inputTokens[2];
                    if (tickets.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carPlate}");
                    }
                    else
                    {
                        tickets.Add(name, carPlate);
                        Console.WriteLine($"{name} registered {carPlate} successfully");
                    }
                   
                    
                }
                else if (command == "unregister")
                {
                    if (!tickets.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        tickets.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }

                }
                
            }
            foreach (var pair in tickets)
            {
                Console.WriteLine(pair.Key + " => " + pair.Value);
            }
        }
    }
}
