using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HelloFrance_10.March._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|");
            double budget = double.Parse(Console.ReadLine());

            List<double> newPrices = new List<double>();

            for (int i = 0; i < array.Length; i++)
            {
                string[] input = array[i].Split("->");
                string item = input[0];
                double price = double.Parse(input[1]);
                double maxPrice = 0;

                if (item == "Clothes")
                {
                    maxPrice = 50.00;
                }
                else if (item == "Shoes")
                {
                    maxPrice = 35.00;
                }
                else if (item == "Accessories")
                {
                    maxPrice = 20.50;
                }

                if (budget >= price && price <= maxPrice)
                {
                    budget -= price;
                    newPrices.Add(price * 1.4);
                }
            }
            for (int i = 0; i < newPrices.Count; i++)
            {
                Console.Write($"{newPrices[i]:f2} ");
            }
            Console.WriteLine();
            budget += newPrices.Sum();
            double profit = newPrices.Sum() - newPrices.Sum() / 1.4;
            Console.WriteLine($"Profit: {profit:f2}");

            if (budget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

        }
    }
}
