using System;
using System.Text;
using System.Linq;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "TakeOdd":
                        string newPass = "";
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                newPass += password[i];
                            }
                        }
                        password = newPass;
                        Console.WriteLine(newPass);
                        break;

                    case "Cut":
                        int index = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);    
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;

                    case "Substitute":
                        string substring = tokens[1];
                        string substitute = tokens[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine($"Nothing to replace!");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
