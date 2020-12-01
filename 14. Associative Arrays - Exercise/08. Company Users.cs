using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputTokens = input.Split(" -> ");
                string companyName = inputTokens[0]; // string name = input.Split(" -> ")[0];
                string id = inputTokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(id);
                }
                else
                {
                    List<string> ids = companies[companyName];
                    if (!ids.Contains(id))
                    {
                        companies[companyName].Add(id);
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var pair in companies)
            {
                Console.WriteLine(pair.Key);

                foreach (string id in pair.Value)
                {
                    Console.WriteLine("-- " + id);
                }
                
            }
        }
    }
}
