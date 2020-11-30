using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Threading;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int orginal = n;
            int targetsCount = 0;

            while (orginal >= m)
            {
                orginal -= m;
                targetsCount++;

                if (orginal == n * 0.5 && y != 0)
                {
                    orginal /= y;
                }
            }

            Console.WriteLine(orginal);
            Console.WriteLine(targetsCount);
        }
    }
}
