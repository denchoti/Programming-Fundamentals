using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheFinalQuest_10.March._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split();
                string action = command[0];

                if (action == "Delete" )
                {
                    int index = int.Parse(command[1]) + 1;
                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                    
                }

                if (action == "Swap")
                {
                    string firstWord = command[1];
                    string secondWord = command[2];

                    if (list.Contains(firstWord) && list.Contains(secondWord))
                    {
                        int firstWordIndex = list.IndexOf(firstWord);
                        int secondWordIndex = list.IndexOf(secondWord);

                        list[firstWordIndex] = secondWord;
                        list[secondWordIndex] = firstWord;
                    }
                }

                if (action == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]) - 1;

                    if (index >= 0 && index <= list.Count)
                    {
                        list.Insert(index, word);
                    }
                }

                if (action == "Sort")
                {
                    list = list.OrderByDescending(x => x).ToList();
                    // list.Sort();
                    // list.Reverse();
                }

                if (action == "Replace")
                {
                    string firstWord = command[1];
                    string secondWord = command[2];

                    if (list.Contains(secondWord))
                    {
                        int indexSecondWord = list.IndexOf(secondWord);
                        list[indexSecondWord] = firstWord;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
