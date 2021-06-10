using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            

            input.ForEach(delegate (String input)
            {
                input = "Sir " + input;
                Console.WriteLine(input.ToString());
            });
        }
    }
}
