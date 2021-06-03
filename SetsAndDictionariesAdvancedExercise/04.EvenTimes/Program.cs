using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers.Add(input);
            }

            int evenNumber = numbers.Find(x => x % x == 0);

            Console.WriteLine(evenNumber);
        }
    }
}
