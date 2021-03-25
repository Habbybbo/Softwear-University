using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int wagonMaxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string imput = Console.ReadLine();

                if (imput == "end")
                {
                    break;
                }

                string[] token = imput.Split();

                if (token[0] == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    wagons.Add(numberToAdd);
                }
                else
                {
                    int numberToAdd = int.Parse(token[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + numberToAdd <= wagonMaxCapacity)
                        {
                            wagons[i] += numberToAdd;
                            break;
                        }
                    }
                }
                

            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
