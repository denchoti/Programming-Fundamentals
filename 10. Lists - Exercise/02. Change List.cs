using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] elements = command.Split();

                if (elements[0] == "Delete")
                {
                    int elementToDelete = int.Parse(elements[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == elementToDelete)
                        {
                            numbers.RemoveAt(i);
                            i--; 
                        }
                    }
                    
                }
                else if (elements[0] == "Insert")
                {
                    int elementToInsert = int.Parse(elements[1]);
                    int index = int.Parse(elements[2]);

                    numbers.Insert(index,elementToInsert);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));


        }
    }
}
