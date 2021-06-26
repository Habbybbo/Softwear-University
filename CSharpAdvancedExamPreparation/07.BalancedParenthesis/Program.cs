using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charInput = Console.ReadLine().ToCharArray();

            Queue<char> charQueue = new Queue<char>();
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < charInput.Length / 2; i++)
            {
                char currentChar = charInput[i];
                charQueue.Enqueue(currentChar);
            }

            for (int i = charInput.Length / 2; i < charInput.Length; i++)
            {
                char currentChar = charInput[i];
                charStack.Push(currentChar);
            }

            bool areEqual = true;

            for (int i = 0; i < charQueue.Count; i++)
            {
                char currentQueueChar = charQueue.Dequeue();
                char currentStackChar = charStack.Pop();

                //{, }, (, ), [,].

                if (currentQueueChar == '{' && currentStackChar == '}' || currentQueueChar == '(' && currentStackChar == ')' || currentQueueChar == '[' && currentStackChar == ']')
                {
                    areEqual = true;
                }

                else
                {
                    areEqual = false;
                }
            }

            if (areEqual == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
