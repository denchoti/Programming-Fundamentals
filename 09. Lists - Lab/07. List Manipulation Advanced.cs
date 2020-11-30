using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            bool isChanged = false;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();

                if (tokens[0] == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                    isChanged = true;
                }
                if (tokens[0] == "Remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove);
                    isChanged = true;
                }
                if (tokens[0] == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(tokens[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                    isChanged = true;
                }
                if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToBeInsered = int.Parse(tokens[2]);
                    numbers.Insert(indexToBeInsered, numberToInsert);
                    isChanged = true;
                }
                if (tokens[0] == "Contains")
                {
                    int numberContained = int.Parse(tokens[1]);
                    bool check = numbers.Contains(numberContained);
                    if (check)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (tokens[0] == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                    Console.WriteLine();
                }
                if (tokens[0] == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                    Console.WriteLine();
                }
                if (tokens[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                if (tokens[0] == "Filter")
                {
                    string symbol = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (tokens[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < index)));
                    }
                    else if (tokens[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > index)));
                    }
                    else if (tokens[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= index)));
                    }
                    else if (tokens[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= index)));
                    }
                }
            }
            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        public static void PrintEvenNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
        public static void PrintOddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumberOdd = numbers[i];
                if (currentNumberOdd % 2 == 1)
                {
                    Console.Write(currentNumberOdd + " ");
                }

            }


        }
    }
}
