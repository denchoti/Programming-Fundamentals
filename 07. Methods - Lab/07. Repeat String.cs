using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input,n));
        }
        static string RepeatString(string toRepeat, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += toRepeat;
            }
            return result;
        }
    }
}
