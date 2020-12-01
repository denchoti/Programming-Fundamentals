using System;
using System.Threading;


namespace _01.ComputerStore_12.August._2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sumWithoutTax = 0;
            double taxes = 0;

            

            while (input != "special" && input != "regular")
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid price!");
                    
                }
                else if (double.Parse(input) == 0)
                {
                    Console.WriteLine("Invalid order!");
                    
                }
                else if (double.Parse(input) > 0)
                {
                    sumWithoutTax += double.Parse(input);
                }
                
                input = Console.ReadLine();

            }

            taxes = sumWithoutTax * 20 / 100;
            double totalPrice = sumWithoutTax + taxes;

            if (input == "special")
            {
                double sumSpecial = totalPrice - (totalPrice * 10 / 100);
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {sumSpecial:f2}$");
                return;
            }
            else if (input == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
                return;
            }


        }
    }
}
