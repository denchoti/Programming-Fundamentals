using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            switch (type)
            {
                case"Students":
                    switch (day)
                    {
                        case"Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;   
                    }
                    if (count >= 30)
                    {
                        price = price - (price * 15 / 100);
                    }
                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                   
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    if (count >= 10 && count <= 20)
                    {
                        price = price - (price * 5 / 100);
                    }
                    break;

            }
            double totalPrice = price * count;
            if (type == "Business" && count >= 100)
            {
                totalPrice = totalPrice - (10 * price);
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
