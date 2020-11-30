using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            
            foreach (var item2 in array2)
            {
                foreach (var item1 in array1)
                {
                    if (item2 == item1)
                    {
                        Console.Write(item2 + " ");
                        
                    }
                }
            }


        }
    }
}
