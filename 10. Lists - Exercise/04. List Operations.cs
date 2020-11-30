using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] elements = command.Split();
                switch (elements[0])
                {
                    case"Add":
                        int numberToAdd = int.Parse(elements[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int index = int.Parse(elements[2]);
                        if (index >= 0 && index <= numbers.Count)
                        {
                            numbers.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int indexAt = int.Parse(elements[1]);
                        if (indexAt >= 0 && indexAt <= numbers.Count)
                        {
                            numbers.RemoveAt(indexAt);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(elements[2]);
                        if (elements[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstNumber = numbers[0];
                                numbers.Add(firstNumber);
                                numbers.RemoveAt(0);

                            }
                        }
                        else if (elements[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastNumber = numbers[numbers.Count - 1];
                                numbers.Insert(0, lastNumber);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
