using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double spent = 0;


            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought OutFall 4");
                            balance -= 39.99;
                            spent += 39.99;
                        }
                        break;

                    case "CS: OG":
                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought CS: OG");
                            balance -= 15.99;
                            spent += 15.99;
                        }
                        break;

                    case "Zplinter Zell":
                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            balance -= 19.99;
                            spent += 19.99;
                        }
                        break;
                    case "Honored 2":

                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought Honored 2");
                            balance -= 59.99;
                            spent += 59.99;
                        }  
                        break;

                    case "RoverWatch":
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought RoverWatch");
                            balance -= 29.99;
                            spent += 29.99;
                        }   
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            balance -= 39.99;
                            spent += 39.99;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money! ");
                    break;
                }
                input = Console.ReadLine();
                
            }

            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${(spent):f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
