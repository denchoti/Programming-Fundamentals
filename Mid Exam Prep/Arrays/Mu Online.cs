using System;
using System.Linq;

namespace _02.MuOnline_29.February._2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;
            string[] dungeons = Console.ReadLine().Split("|").ToArray();
            
            for (int i = 0; i < dungeons.Length; i++)
            {
                string[] tokens = dungeons[i].Split();
                string command = tokens[0];
                int number = int.Parse(tokens[1]);

                if (command == "potion")
                {
                   
                    if (initialHealth + number <= 100)
                    {
                        initialHealth += number;
                        Console.WriteLine($"You healed for {number} hp.");
                    }
                    else if (initialHealth + number > 100)
                    {
                        int missingHP = 100 - initialHealth;
                        initialHealth += missingHP;
                        Console.WriteLine($"You healed for {missingHP} hp.");
                        
                    }
                    
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    initialBitcoins += number;
                }
                else
                {
                    initialHealth -= number;
                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");

                    }
                    
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {initialBitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
