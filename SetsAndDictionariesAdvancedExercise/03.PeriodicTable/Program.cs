using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> compounds = new HashSet<string>();

            SortedSet<string> sortedCompounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    compounds.Add(input[j]);
                }

            }

            foreach (var element in compounds)
            {
                sortedCompounds.Add(element);
            }

            Console.WriteLine(string.Join(' ', sortedCompounds));

            


        }
    }
}
