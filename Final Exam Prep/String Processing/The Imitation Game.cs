using System;
using System.Linq;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] tokens = input.Split("|");
                string command = tokens[0];
                switch (command)
                {
                    case "Move":
                        int count = int.Parse(tokens[1]);
                        string toMove = message.Substring(0, count);
                        message = message.Remove(0, count);
                        message += toMove;
                        break;

                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string value = tokens[2];
                        message = message.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string substring = tokens[1];
                        string replacement = tokens[2];
                        message = message.Replace(substring, replacement);
                        break;
                        
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
