using System;
using System.Collections.Generic;
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
            int countOpen = 0;
            int countClosed = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input =="(")
                {
                    countOpen++;
                }
                else if (input == ")")
                {
                    countClosed++;

                    if (countOpen  - countClosed != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (countOpen == countClosed)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
           
        }
    }
}
