using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[+][359]+([ -])[2]\1(\d{3})\1(\d{4})\b";

            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
