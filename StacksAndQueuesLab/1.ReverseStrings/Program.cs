using System;
using System.Collections.Generic;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reverseInput = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                reverseInput.Push(currentChar);
            }

            while (reverseInput.Count > 0)
            {
                Console.Write(reverseInput.Pop());
            }
        }
    }
}
