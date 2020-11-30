using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double courses = count / capacity;
            Console.WriteLine($"{Math.Ceiling(courses)}");

        }
    }
}
