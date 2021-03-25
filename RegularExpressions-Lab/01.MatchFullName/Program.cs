using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string imput = Console.ReadLine();

            var match = Regex.Matches(imput, regex);

            Console.WriteLine(string.Join(' ',match));
        }
    }
}
