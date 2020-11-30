using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(PrintMiddleCharacter(text));

        }
        static string PrintMiddleCharacter(string input)
        {
            int middle = input.Length;
            string result = "";
 
            if(middle % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
 
            return result;
            
        }
    }
}
