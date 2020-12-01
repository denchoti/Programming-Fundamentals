using System;
using System.Linq;

namespace _02.NumberArray_30.June._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = "";

            while ((input = Console.ReadLine()) != "End")

            {
                string[] command = input.Split().ToArray();
                int index = 0;
                int sumNegative = 0;
                int sumPositive = 0;
                int sumAll = 0;

                switch (command[0])
                {
                    case "Switch":
                        index = int.Parse(command[1]);
                        if (index < 0 || index >= numbers.Length)
                        {
                            continue;
                        }
                        numbers[index] = numbers[index] * -1;
                        break;

                    case "Change":
                        index = int.Parse(command[1]);
                        if (index < 0 || index >= numbers.Length)
                        {
                            continue;
                        }
                        int numValue = int.Parse(command[2]);
                        numbers[index] = numValue;
                        break;

                    case "Sum":
                        string commandSum = command[1];
                        if (commandSum == "Negative")
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] < 0)
                                {
                                    sumNegative += numbers[i];
                                }
                            }
                            Console.WriteLine(sumNegative);
                        }
                        else if (commandSum == "Positive")
                        {
                            for (int i = 0; i < numbers.Length; i++)

                            {
                                if (numbers[i] >= 0)

                                {
                                    sumPositive += numbers[i];
                                }


                            }
                            Console.WriteLine(sumPositive);
                        }
                        else if (commandSum == "All")
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                sumAll += numbers[i];
                            }
                            Console.WriteLine(sumAll);
                        }
                        break;
                }
            }
            foreach (int number in numbers)
            {
                if (number >= 0)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
