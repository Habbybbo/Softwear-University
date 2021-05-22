using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];

                if (currentNum % 2 == 0)
                {
                    queue.Enqueue(currentNum);
                }
            }

            Console.Write(string.Join(", ", queue));
        }
    }
}
