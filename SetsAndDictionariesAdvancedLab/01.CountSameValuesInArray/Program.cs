using System;
using System.Collections.Generic;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counter = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentNumber = input[i];

                if (counter.ContainsKey(currentNumber))
                {
                    counter[currentNumber]++;
                }
                else
                {
                    counter.Add(currentNumber, 1);
                }
            }

            foreach (var number in counter)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
