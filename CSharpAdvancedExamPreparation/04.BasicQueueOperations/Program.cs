using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < comands[0]; i++)
            {
                int currentNumber = input[i];
                numbers.Enqueue(currentNumber);
            }

            for (int i = 0; i < comands[1]; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(comands[2]))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
