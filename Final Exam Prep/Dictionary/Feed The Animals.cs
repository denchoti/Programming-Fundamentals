using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, int> animalDailyLimit = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimals = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            // Add:Maya:7600:WaterfallArea

            while (input != "Last Info")
            {
                string[] cmdArgs = input.Split(":");
                string command = cmdArgs[0]; //Add
                string animalName = cmdArgs[1]; //Maya
                int food = int.Parse(cmdArgs[2]); //7600
                string area = cmdArgs[3]; //WaterfallArea

                switch (command)
                {
                    case"Add":
                        if (!animalDailyLimit.ContainsKey(animalName))
                        {
                            animalDailyLimit[animalName] = 0; //Maya - key

                        }
                        animalDailyLimit[animalName] += food; //food - value

                        if (!areaAnimals.ContainsKey(area))
                        {
                            areaAnimals[area] = new List<string>();   //no area- we add it as list-  
                        }

                        if (!areaAnimals[area].Contains(animalName))  //if we have the area and not the animal in it we add it
                        {
                            areaAnimals[area].Add(animalName);
                        }
                        break;

                    case "Feed":
                        if (animalDailyLimit.ContainsKey(animalName))
                        {
                            animalDailyLimit[animalName] -= food;
                            if (animalDailyLimit[animalName] < 1)
                            {
                                animalDailyLimit.Remove(animalName);
                                areaAnimals[area].Remove(animalName);
                                Console.WriteLine($"{animalName} was successfully fed");
                            }
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            animalDailyLimit = animalDailyLimit
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            areaAnimals = areaAnimals
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Animals:");
            foreach (var animal in animalDailyLimit)
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in areaAnimals)
            {
                Console.WriteLine($"{area.Key} : {area.Value.Count}");
            }
            */

            Dictionary<string, int> animalsAndFoodLimit = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimals = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Last Info")
            {
                string[] cmdArgs = input.Split(":");
                string command = cmdArgs[0];
                string name = cmdArgs[1];
                int food = int.Parse(cmdArgs[2]);
                string area = cmdArgs[3];

                switch (command)
                {
                    case "Add":
                        if (!animalsAndFoodLimit.ContainsKey(name))
                        {
                            animalsAndFoodLimit.Add(name, 0);
                        }
                        animalsAndFoodLimit[name] += food;

                        if (!areaAnimals.ContainsKey(area))
                        {
                            areaAnimals[area] = new List<string>();
                        }
                        if (!areaAnimals[area].Contains(name))
                        {
                            areaAnimals[area].Add(name);
                        }
                        break;


                    case "Feed":
                        if (animalsAndFoodLimit.ContainsKey(name))
                        {
                            animalsAndFoodLimit[name] -= food;

                            if (animalsAndFoodLimit[name] < 1)
                            {
                                Console.WriteLine($"{name} was successfully fed");
                                animalsAndFoodLimit.Remove(name);
                                areaAnimals[area].Remove(name);
                            }
                        }

                        break;
                }


                input = Console.ReadLine();

            }
            Console.WriteLine("Animals:");
            animalsAndFoodLimit = animalsAndFoodLimit
                                 .OrderByDescending(x => x.Key)
                                 .ThenBy(x => x.Value)
                                 .ToDictionary(x => x.Key, y => y.Value);

            foreach (var animal in animalsAndFoodLimit)
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            areaAnimals = areaAnimals.Where(x => x.Value.Count > 0)
                                     .OrderByDescending(x => x.Key)
                                     .ThenBy(x => x.Value)
                                     .ToDictionary(x => x.Key, y => y.Value);

            foreach (var area in areaAnimals)
            {
                Console.WriteLine($"{area.Key} : {area.Value.Count}");

            }
        }
    }
}
