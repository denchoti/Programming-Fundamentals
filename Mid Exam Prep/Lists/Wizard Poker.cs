using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03.Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> deck = new List<string>();

            string input = Console.ReadLine();

            while (input != "Ready")
            {
                string[] commands = input.Split();
                string command = commands[0];
                string cardName = commands[1];

                switch (command)
                {
                    case "Add":
                        if (cards.Contains(cardName))
                        {
                            deck.Add(cardName);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(commands[2]);                      
                        if (cards.Contains(cardName) && index >= 0 && index <= deck.Count - 1)
                        {
                            deck.Insert(index, cardName);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;

                    case "Remove":
                        if (deck.Contains(cardName))
                        {
                            deck.Remove(cardName);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;

                    case "Swap":
                        string cardName2 = commands[2];
                        int first = deck.IndexOf(cardName);
                        int second = deck.IndexOf(cardName2);

                        string temp = deck[first];
                        deck[first] = deck[second];
                        deck[second] = temp;
                        break;

                    case "Shuffle":
                        deck.Reverse();
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
