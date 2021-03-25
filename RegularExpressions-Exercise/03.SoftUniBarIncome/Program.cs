using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"%(?<name>[A-Z][a-z]+)%<(?<product>[A-Z][a-z]+)>\w*?\|(?<quantity>\d+)\|\w*?(?<price>\d+\.?\d+)\$";

            double totalIncome = 0;

            string imput = Console.ReadLine();

            while (imput != "end of shift")
            {

                Match regex = Regex.Match(imput, patern);

                if (regex.Success)
                {
                    string customer = regex.Groups[1].Value;
                    string product = regex.Groups[2].Value;
                    double customerSum = int.Parse(regex.Groups[3].Value) * double.Parse(regex.Groups[4].Value);

                    totalIncome += customerSum;

                    Console.WriteLine($"{customer}: {product} - {customerSum:F2}");
                }

                

                imput = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
