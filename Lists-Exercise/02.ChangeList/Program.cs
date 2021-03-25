using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "end")
                {
                    break;
                }

                string[] elements = commands.Split();

                if (elements[0] == "Delete")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        int numToDelete = int.Parse(elements[1]);
                        nums.Remove(numToDelete);
                    }
                    
                }
                
                else if (elements[0] == "Insert")
                {
#pragma warning disable CS0162 // Unreachable code detected
                    for (int i = 0; i < nums.Count; i++)
#pragma warning restore CS0162 // Unreachable code detected
                    {
                        int numToInsert = int.Parse(elements[1]);
                        int position = int.Parse(elements[2]);
                        nums.Insert(position, numToInsert);
                        break;
                        
                    }
                    
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
