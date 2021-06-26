using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (comands[0] == 1)
                {
                    numbers.Push(comands[1]);
                }
                else if (comands[0] == 2)
                {
                    numbers.Pop();
                }
                else if (comands[0] == 3)
                {
                    Console.WriteLine(numbers.Max());
                }
            }
        }
    }
}
