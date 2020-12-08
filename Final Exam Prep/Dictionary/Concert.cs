using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> bandAndMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();

            string input = Console.ReadLine();
            int totalTime = 0;

            while (input != "start of concert")
            {
                string[] cmdArgs = input.Split("; ");
                string command = cmdArgs[0];
                string bandName = cmdArgs[1];

                switch (command)
                {
                    case "Add":
                        List<string> members = cmdArgs[2].Split(", ").ToList();

                        if (!bandAndMembers.ContainsKey(bandName))
                        {
                            bandAndMembers.Add(bandName, members);

                        }
                        else
                        {
                            foreach (var member in members)
                            {
                                if (!bandAndMembers.ContainsKey(member))
                                {
                                    bandAndMembers[bandName].Add(member);
                                }
                            }
                        }
                        break;

                    case "Play":
                        int time = int.Parse(cmdArgs[2]);
                        if (!bandTime.ContainsKey(bandName))
                        {
                            bandTime.Add(bandName, time);
                        }
                        else
                        {
                            bandTime[bandName] += time;

                        }
                        totalTime += time;
                        break;
                }

                input = Console.ReadLine();
            }
            string bandPrint = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");

            bandTime = bandTime
                      .OrderByDescending(x => x.Key)
                      .ThenBy(x => x.Value)
                      .ToDictionary(x => x.Key, y => y.Value);

            foreach (var band in bandTime)
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            Console.WriteLine(bandPrint);

            bandAndMembers = bandAndMembers
                             .OrderBy(x => x.Key)
                             .ThenBy(x => x.Value)
                             .ToDictionary(x => x.Key, y => y.Value);

            foreach (var band in bandAndMembers[bandPrint])
            {
                Console.WriteLine($"=> {band}");
            }
        }
    }
}
