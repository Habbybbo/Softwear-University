using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n)
                .ToArray();

            int count = sorted.Length >= 3 ? 3 : sorted.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
        }
    }
}
