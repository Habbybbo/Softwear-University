using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Push(input[i]);
            }


            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
