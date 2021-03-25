using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            List<string> furniture = new List<string>();
            double totalSum = 0;

            string imput = Console.ReadLine();

            while (imput != "Purchase")
            {
                
                MatchCollection matches = Regex.Matches(imput, patern);

                foreach (Match item in matches)
                {
                    furniture.Add(item.Groups[1].Value);
                    totalSum += double.Parse(item.Groups["price"].Value) * double.Parse(item.Groups["quantity"].Value);
                }

                imput = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (totalSum > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
