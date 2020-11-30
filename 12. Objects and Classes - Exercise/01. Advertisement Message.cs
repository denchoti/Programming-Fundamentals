using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AdvertisementMessage ad = new AdvertisementMessage();
                Console.WriteLine(ad.GenerateMessage());
            }
        }

    }
    public class AdvertisementMessage
    {
        public string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        public string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        public string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        public string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public string GenerateMessage()
        {
            Random rand = new Random();
            string currentPhrase = phrases[rand.Next(0, phrases.Length - 1)];
            string currentEvent = events[rand.Next(0, events.Length - 1)];
            string currentAuthor = authors[rand.Next(0, authors.Length - 1)];
            string currentCity = cities[rand.Next(0, cities.Length - 1)];

            return $"{currentPhrase} {currentEvent} {currentAuthor} – {currentCity}";

        }

    }
}
