using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(AdvertisementMessage.GenerateMessage());
            }
            
        }

        public class AdvertisementMessage
        {
            public static string[] Phrases = new string[] {"Excellent product.", "Such a great product.", 
                "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            public static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. " +
                "I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            public static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public static string GenerateMessage()
            {
                Random rand = new Random();
                string currentPhrase = Phrases[rand.Next(0, Phrases.Length - 1)];
                string currentEvent = Events[rand.Next(0, Events.Length - 1)];
                string currentAuthor = Authors[rand.Next(0, Authors.Length - 1)];
                string currentCity = Cities[rand.Next(0, Cities.Length - 1)];

                return $"{currentPhrase} {currentEvent} {currentAuthor} – {currentCity}";
            }

        }
    }
}
