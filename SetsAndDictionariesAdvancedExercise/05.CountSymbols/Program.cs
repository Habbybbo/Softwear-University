using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> charDictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (charDictionary.ContainsKey(currentSymbol))
                {
                    charDictionary[currentSymbol]++;
                }
                else
                {
                    charDictionary.Add(currentSymbol, 1);
                }
            }

            foreach (var item in charDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
