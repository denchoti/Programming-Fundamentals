using System;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (array.Length != 1)
            {
                int[] newArray = new int[array.Length - 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i] + array[i + 1];
                }
                array = newArray;
            }
            
            Console.WriteLine(string.Join(" ",array));
           
        }
    }
}
