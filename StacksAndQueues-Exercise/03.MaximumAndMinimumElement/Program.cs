using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(); 

            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                if (input[0] == 1)
                {
                    int numToPush = input[1];
                    stack.Push(numToPush);
                }
                else if (input[0] == 2)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else if (input[0] == 3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (input[0] == 4)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
