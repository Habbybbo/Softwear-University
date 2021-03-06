using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int tottalFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            for (int i = 0; i < orders.Length; i++)
            {
                if (tottalFood <= 0)
                {
                    break;
                }
                else if (tottalFood >= queue.Peek())
                {
                    tottalFood -= queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
