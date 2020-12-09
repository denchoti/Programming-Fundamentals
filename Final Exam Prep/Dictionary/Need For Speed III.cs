using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split("|");
                string name = tokens[0];
                int mileage = int.Parse(tokens[1]);
                int fuel = int.Parse(tokens[2]);

                if (!cars.ContainsKey(name))
                {
                    cars.Add(name, new List<int> { mileage, fuel });
                }
            }

            string commands = Console.ReadLine();
            while (commands != "Stop")
            {
                string[] cmdArgs = commands.Split(" : ");
                string command = cmdArgs[0];
                string name = cmdArgs[1];

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(cmdArgs[2]);
                        int fuelNeeded = int.Parse(cmdArgs[3]);
                        if (fuelNeeded <= cars[name][1])
                        {
                            cars[name][0] += distance;
                            cars[name][1] -= fuelNeeded;
                            Console.WriteLine($"{name} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                            if (cars[name][0] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {name}!");
                                cars.Remove(name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        break;

                    case "Refuel":
                        int refill = int.Parse(cmdArgs[2]);
                        if ((cars[name][1] + refill) < 75)
                        {
                            cars[name][1] += refill;
                        }
                        else
                        {
                            refill = 75 - cars[name][1];
                            cars[name][1] = 75;
                        }
                        Console.WriteLine($"{name} refueled with {refill} liters");
                        break;

                    case "Revert":
                        int kilometers = int.Parse(cmdArgs[2]);
                        cars[name][0] -= kilometers;
                        
                        if (cars[name][0] < 10000)
                        {
                            cars[name][0] = 10000;

                        }
                        else
                        {
                            Console.WriteLine($"{name} mileage decreased by {kilometers} kilometers");
                        }
                        break;
                }
                commands = Console.ReadLine();
            }

            cars = cars.OrderByDescending(x => x.Value[0])
                       .ThenBy(x => x.Key)
                       .ToDictionary(x => x.Key, y => y.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
