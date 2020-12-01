using System;

namespace _01.NationalCourt_29.February._2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());

            int effeciencyAll = employee1 + employee2 + employee3; // for one hour all of them
            int hours = 0;

            while (countPeople > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                countPeople -= effeciencyAll;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
