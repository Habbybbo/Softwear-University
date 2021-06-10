using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;
            Func<int, int> arithmeticFunc = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    arithmeticFunc = num => num + 1;
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }
                else if (command == "multiply")
                {
                    arithmeticFunc = num => num * 2;
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }
                else if (command == "subtract")
                {
                    arithmeticFunc = num => num - 1;
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
