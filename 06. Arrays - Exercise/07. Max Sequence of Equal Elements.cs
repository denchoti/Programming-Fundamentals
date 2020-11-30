using System;
using System.Linq;
using System.Threading;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;

            //2 1 1 2 3 3 2 2 2 1
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1]) //сравняваме с предишния елемент 
                {
                    length++; //ако са равни увеличаваме дължината
                }
                else
                {
                    length = 1; //ако не са си остава 1 и почваме следващата цифра да сравняваме
                    start = i;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
