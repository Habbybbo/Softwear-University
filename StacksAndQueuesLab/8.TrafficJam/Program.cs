using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToPass = int.Parse(Console.ReadLine());
            string cars = Console.ReadLine();

            Queue<string> carsQueue = new Queue<string>();

            int passCounter = 0;

            while (cars != "end")
            {

                if (cars != "green" && cars != "end")
                {
                    carsQueue.Enqueue(cars);
                }

                if (cars == "green")
                {
                    for (int i = 0; i <= numberToPass - 1; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        passCounter++;

                        if (carsQueue.Count <= 0)
                        {
                            break;
                        }
                    }
                }

                cars = Console.ReadLine();
            }

            Console.WriteLine($"{passCounter} cars passed the crossroads.");
        }
    }
}
