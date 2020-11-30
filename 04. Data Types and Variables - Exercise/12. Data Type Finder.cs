using System;

namespace ME._1.DataTypeFinder
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool intTryParse = int.TryParse(input, out int intValue);
                bool floatTryParse = float.TryParse(input, out float floatValue);
                bool charTryParse = char.TryParse(input, out char charValue);
                bool boolTryParse = bool.TryParse(input, out bool boolValue);

                if (intTryParse)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (floatTryParse)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (charTryParse)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (boolTryParse)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
