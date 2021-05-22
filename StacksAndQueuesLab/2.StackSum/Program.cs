using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Stack<int> numInput = new Stack<int>(input);

            string command = Console.ReadLine();

            while (command.ToUpper() != "END")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0].ToUpper() == "ADD")
                {
                    numInput.Push(int.Parse(tokens[1]));
                    numInput.Push(int.Parse(tokens[2]));
                }
                else if (tokens[0].ToUpper() == "REMOVE")
                {
                    int numsToRemove = int.Parse(tokens[1]);

                    if (numsToRemove < numInput.Count)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            numInput.Pop();
                        }
                    }
                    
                }



                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {numInput.Sum()}");
        }
    }
}
