using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            //input.ForEach(PrintConsole);

            input.ForEach(delegate (String input)
            {
                Console.WriteLine(input);
            });
            
        }

        private static void PrintConsole(string input)
        {
            Console.WriteLine(input);
        }
    }
}
