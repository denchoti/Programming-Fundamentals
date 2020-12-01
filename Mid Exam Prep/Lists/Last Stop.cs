using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LastStop_10.March._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commands = input.Split();
                string command = commands[0];


                if (command == "Change")
                {
                    int paintingNumber = int.Parse(commands[1]);
                    int newNumber = int.Parse(commands[2]);

                    if (list.Contains(paintingNumber))
                    {
                        int firstIndex = list.IndexOf(paintingNumber);
                        list[firstIndex] = newNumber;
                    }
                }

                if (command == "Hide")
                {
                    int paintingNumber = int.Parse(commands[1]);
                    if (list.Contains(paintingNumber))
                    {
                        list.Remove(paintingNumber);
                    }
                }

                if (command == "Switch")
                {
                    int paintingNumber = int.Parse(commands[1]);
                    int paintingNumber2 = int.Parse(commands[2]);

                    if (list.Contains(paintingNumber) && list.Contains(paintingNumber2))
                    {
                        int firstIndex = list.IndexOf(paintingNumber);
                        int secondIndex = list.IndexOf(paintingNumber2);

                        list[firstIndex] = paintingNumber2;
                        list[secondIndex] = paintingNumber;
                    }
                }

                if (command == "Insert")
                {
                    int place = int.Parse(commands[1]) + 1;
                    int paintingNumber = int.Parse(commands[2]);

                    if (place > 0 && place < list.Count)
                    {
                        list.Insert(place, paintingNumber);
                    }
                }

                if (command == "Reverse")
                {
                    list.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
