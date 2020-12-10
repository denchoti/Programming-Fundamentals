using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");

                string name = input[0];
                double rarity = double.Parse(input[1]);

                if (!plants.ContainsKey(name))
                {
                    plants.Add(name, new List<double>());
                    plants[name].Add(rarity);
                }
                else
                {
                    plants[name][0] += rarity;
                }
            }
            while (true)
            {
                string input2 = Console.ReadLine();

                if (input2 == "Exhibition")
                {
                    break;
                }

                string[] tokens = input2.Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string plant = tokens[1];
                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }
                switch (command)
                {
                    case "Rate":
                        double rating = double.Parse(tokens[2]);
                        plants[plant].Add(rating);
                        break;

                    case "Update":
                        double newRarity = double.Parse(tokens[2]);
                        plants[plant][0] = newRarity;
                        break;

                    case "Reset":
                        plants[plant].RemoveRange(1, plants[plant].Count - 1);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            foreach (var plant in plants)
            {
                double rarity = plant.Value[0]; //saving the value of the rarity before we remove it
                plant.Value.RemoveAt(0);        //removing the rarity so we can use the .Count only on the ratings

                int count = plant.Value.Count;
                double average = plant.Value.Sum();

                if (average > 0)
                {
                    average /= count;       //getting the average rating
                }
                plant.Value.Clear();        //removing all existing values
                plant.Value.Add(rarity);    //adding the initial rarity (unchanged)
                plant.Value.Add(average);   //adding the average of the ratings 
            }

            Console.WriteLine("Plants for the exhibition:");
            plants = plants.OrderByDescending(x => x.Value[0])
                           .ThenByDescending(x => x.Value[1])
                           .ToDictionary(x => x.Key, y => y.Value);

            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {(int)plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }
    }
}
