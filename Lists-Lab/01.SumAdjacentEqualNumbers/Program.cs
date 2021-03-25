using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int n = numbers.Count;

            for (int i = 0; i < n; i++) // Not working, needs to be finished.
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];

                    numbers.RemoveAt(i + 1);
                    i = -1;

                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
