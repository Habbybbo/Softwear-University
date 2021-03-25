using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namesAndKm = new Dictionary<string, int>();


            string[] contestants = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string imput = Console.ReadLine();

            while (imput != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string digitPatern = @"\d";

                var nameMatch = Regex.Matches(imput, namePattern);
                var kmMatch = Regex.Matches(imput, digitPatern);

                var name = String.Concat(nameMatch);
                var sumOfKm = kmMatch.Select(x => int.Parse(x.Value)).Sum();

                if (contestants.Contains(name))
                {
                    if (namesAndKm.ContainsKey(name))
                    {
                        namesAndKm[name] += sumOfKm;
                    }
                    else
                    {
                        namesAndKm.Add(name, sumOfKm);
                    }
                }

                imput = Console.ReadLine();
            }

            var sorted = namesAndKm.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);


        }
    }
}
