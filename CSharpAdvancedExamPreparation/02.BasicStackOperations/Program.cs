using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            //You will be given an integer N representing the number of elements to push onto the stack, 
            //    an integer S representing the number of elements to pop from the stack and finally an integer X, 
            //    an element that you should look for in the stack.If it’s found, print “true” on the console.If it isn’t, 
            //    print the smallest element currently present in the stack.

            for (int i = 0; i < comands[0]; i++)
            {
                int currentNumbers = input[i];
                numbers.Push(currentNumbers);
            }

            for (int i = 0; i < comands[1]; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(comands[2]))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            
            



        }
    }
}
