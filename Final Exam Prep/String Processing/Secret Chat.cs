using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] tokens = input.Split(":|:");
                string command = tokens[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(tokens[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        string substring = tokens[1];
                        if (message.Contains(substring))
                        {
                            int start = message.IndexOf(substring);
                            message = message.Remove(start, substring.Length);
                            // alternative 1:
                            //string reversed = "";

                            //for (int i = substring.Length - 1; i >= 0; i--)
                            //{
                            //    reversed += substring[i];
                            //}
                            //message = message + reversed;
                            var reversed = String.Concat(substring.Reverse());
                            //alternative 2:
                            // var reversed = new string(substring.Reverse().ToArray());
                            message = message + reversed;
                            Console.WriteLine(message); 
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        string old = tokens[1];
                        string replacement = tokens[2];
                        message = message.Replace(old, replacement);
                        Console.WriteLine(message);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
