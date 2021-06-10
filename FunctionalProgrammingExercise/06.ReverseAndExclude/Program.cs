using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            Func<int, bool> predicate = num => num % n != 0;
            numbers = numbers.Where(predicate).ToList();

            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            print(numbers);
        }
    }
}
