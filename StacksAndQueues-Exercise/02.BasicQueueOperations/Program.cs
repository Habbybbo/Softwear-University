using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();


            int pushNumber = commands[0];
            int popNumber = commands[1];
            int peekNumber = commands[2];

            for (int i = 0; i < pushNumber; i++)
            {
                int currentNumber = inputNumbers[i];

                queue.Enqueue(currentNumber);
            }

            for (int i = 0; i < popNumber; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(peekNumber))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
