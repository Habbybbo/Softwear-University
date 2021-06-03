using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            HashSet<int> setN = new HashSet<int>(sizes[0]);
            HashSet<int> setM = new HashSet<int>(sizes[1]);

            for (int i = 0; i < sizes[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());

                setN.Add(input);
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (setN.Contains(input))
                {
                    setM.Add(input);
                }
                
            }

            Console.WriteLine(string.Join(' ', setM));

            
        }
    }
}
