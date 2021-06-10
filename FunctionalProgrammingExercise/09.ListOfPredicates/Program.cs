using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> numbers = Enumerable.Range(1, end).ToList();

            foreach (var num in numbers)
            {
                if (dividers.All (d => num % d == 0))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
