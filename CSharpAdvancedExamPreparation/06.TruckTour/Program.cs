using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPumps = int.Parse(Console.ReadLine());

            Queue<int> pumps = new Queue<int>();

            for (int i = 0; i < numOfPumps; i++)
            {
                int[] pumpData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                pumps.Enqueue(pumpData[0]);
                pumps.Enqueue(pumpData[1]);
            }



        }
    }
}
