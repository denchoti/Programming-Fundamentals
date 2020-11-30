using System;
using System.Threading;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            
            int belts = students / 6;
            double students1 = Math.Ceiling((students * 0.1) + students);


            double totalPrice = (students1 * priceLightsabers) + ((students - belts) * priceBelts) + (students * priceRobes);

            if (totalPrice > money)
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - money:f2}lv more.");
            }
            else if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }

        }
    }
}
