using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double sum = 0;

            while (command != "Start")
            {
                double currentAmount = double.Parse(command);
                if (currentAmount != 0.1 && currentAmount != 0.2 && currentAmount != 0.5 && currentAmount != 1 && currentAmount != 2)
                {
                    Console.WriteLine($"Cannot accept {currentAmount}");
                }
                else
                {
                    sum += currentAmount;
                }

                command = Console.ReadLine();
            }
            string product = Console.ReadLine();

            while (product != "End")
            {
                double currentPrice = 0;
                switch (product)
                {
                    case "Nuts":
                        currentPrice = 2.0;
                        break;
                    case "Water":
                        currentPrice = 0.7;
                        break;
                    case "Crisps":
                        currentPrice = 1.5;
                        break;
                    case "Soda":
                        currentPrice = 0.8;
                        break;
                    case "Coke":
                        currentPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        product = Console.ReadLine();
                        continue;
                }
                if (sum >= currentPrice)
                {
                    sum -= currentPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
