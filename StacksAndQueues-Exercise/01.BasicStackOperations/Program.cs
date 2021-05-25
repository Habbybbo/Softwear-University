using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
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

            Stack<int> stack = new Stack<int>();


            int pushNumber = commands[0];
            int popNumber = commands[1];
            int peekNumber = commands[2];

            for (int i = 0; i < pushNumber; i++)
            {
                int currentNumber = inputNumbers[i];

                stack.Push(currentNumber);
            }

            for (int i = 0; i < popNumber; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(peekNumber))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
