using System;
using System.Collections.Generic;

namespace _02MinersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(name))
                {
                    resources[name] += quantity;
                }
                else if (! resources.ContainsKey(name))
                {
                    resources.Add(name, quantity);
                }
            }

            foreach (var pair in resources)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
