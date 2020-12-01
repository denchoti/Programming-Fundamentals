using System;

namespace _01.SpringVacationTrip_10.March._2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());
            decimal fuelPerKm = decimal.Parse(Console.ReadLine());
            decimal foodExpenses = decimal.Parse(Console.ReadLine());
            decimal hotelPerNight = decimal.Parse(Console.ReadLine());


            if (countPeople > 10)
            {
                hotelPerNight = hotelPerNight - (hotelPerNight * 25 / 100);
            }

            decimal expenses = days * countPeople * (foodExpenses + hotelPerNight);
            for (int i = 1; i <= days; i++)
            {

                decimal travelledKm = decimal.Parse(Console.ReadLine());
                decimal fuelExpenses = travelledKm * fuelPerKm;
                expenses += fuelExpenses;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    expenses += expenses * 40 / 100;
                }
                else if (i % 7 == 0)
                {
                    decimal withdrawal = expenses / countPeople;
                    expenses -= withdrawal;
                }

                if (expenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(expenses - budget):F2}$ more.");
                    return;
                }

            }

            decimal left = budget - expenses;
            Console.WriteLine($"You have reached the destination. You have {left:f2}$ budget left.");

        }
    }
}
