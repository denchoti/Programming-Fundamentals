using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.April._2019_01.OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split("->");
                string command = tokens[0];
                string store = tokens[1];

                switch (command)
                {
                    case "Add":
                        string[] items = tokens[2].Split(",");

                        if (!stores.ContainsKey(store))
                        {
                            stores.Add(store, new List<string>());
                        }
                        for (int i = 0; i < items.Length; i++)
                        {
                            stores[store].Add(items[i]);
                        }
                        break;

                    case "Remove":
                        if (stores.ContainsKey(store))
                        {
                            stores.Remove(store);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Stores list:");
            stores = stores.OrderByDescending(x => x.Value.Count)
                           .ToDictionary(x => x.Key, y => y.Value);

            //REMOVED :  .ThenBy(x => x.Key)

            foreach (var store in stores)
            {
                Console.WriteLine(store.Key);
                for (int i = 0; i < store.Value.Count; i++)
                {
                    Console.WriteLine($"<<{store.Value[i]}>>");
                }
            }

            /* 
            foreach (var (store,items) in stores)
            {
                Console.WriteLine(store);
                foreach (var item in items)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
             */
        }
    }
}
