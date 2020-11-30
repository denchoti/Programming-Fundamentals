using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombToKill = bombData[0];
            int power = bombData[1];

            int bombIndex = 0;

            while (numbers.Contains(bombToKill))
            {
                bombIndex = numbers.IndexOf(bombToKill);

                int leftNumbers = power;
                int rightNumbers = power;

                if (bombIndex - leftNumbers < 0)
                {
                    leftNumbers = bombIndex;
                }
                if (bombIndex +rightNumbers >=  numbers.Count)
                {
                    rightNumbers = numbers.Count - bombIndex - 1;
                }

                numbers.RemoveRange(bombIndex -leftNumbers, leftNumbers + rightNumbers + 1);

                bombIndex = numbers.IndexOf(bombToKill);
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

    }
}
