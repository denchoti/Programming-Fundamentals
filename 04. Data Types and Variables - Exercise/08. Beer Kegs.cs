using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = float.MinValue;
            string biggestModel = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);

        }
    }
}
