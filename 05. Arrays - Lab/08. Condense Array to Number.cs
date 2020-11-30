using System;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
            int n = nums.Length;

            for (int i = 0; i < n-1; i++)
            {
                int[] newArr = new int[nums.Length - 1];
                for (int j = 0; j < newArr.Length; j++)
                {
                    newArr[j] = nums[j] + nums[j + 1];
                }
                nums = newArr;
               
            }
            Console.WriteLine(String.Join(" ", nums));
           
        }
    }
}
