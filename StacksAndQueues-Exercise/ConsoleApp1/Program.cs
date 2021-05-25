using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cloths = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(cloths);

            int rackCounter = 1;
            int tottalCloths = 0;

            while (stack.Count > 0)
            {
                var current = stack.Peek();

                if (tottalCloths + current > rackCapacity)
                {
                    rackCounter++;
                    tottalCloths = 0;
                }
                else
                {
                    tottalCloths += stack.Pop();
                }
            }
            

            Console.WriteLine(rackCounter);
        }
    }
}
