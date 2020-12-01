using System;
using System.Collections.Generic;
using System.Security;

namespace _01.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var validUsername = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                if (current.Length >= 3 && current.Length <= 16)
                {

                    bool isValid = true;
                    for (int j = 0; j < current.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        validUsername.Add(current);
                    }
                }

            }

            Console.WriteLine(String.Join(Environment.NewLine, validUsername));
        }
    }
}
