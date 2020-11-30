using System;
using System.Threading;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= (-1);
            }

            while (number % 2 != 0)
            {
                Console.WriteLine($"Please write an even number.");
                number = int.Parse(Console.ReadLine());

                
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
               
            }
        }
    }
}
