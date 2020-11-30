using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end" ) 
            {
                string[] elements = input.Split();

                if (elements[0] == "Add")
                {
                    int passengers = int.Parse(elements[1]);
                    train.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(elements[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if ((train[i] + passengers) <= maxCapacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                       
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",train));

        }
    }
}
