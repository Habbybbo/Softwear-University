using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string operations = Console.ReadLine();

                if (operations == "end")
                {
                    break;
                }

                string[] tokens = operations.Split();

                switch (tokens[0])
                {
                    case "Contains":
                        int numberToContain = int.Parse(Console.ReadLine()); //
                        nums.Contains(numberToContain);                      //
                        Console.WriteLine("Yes");                            //
                        break;                                               // Not working. Experimented with.
                    default:                                                 //
                        Console.WriteLine("No such number");                 //
                        break;                                               //

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        nums.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        nums.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        nums.Insert(indexToInsert, numberToInsert);
                        break;

                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
