using System;
using System.Collections.Generic;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string customer = Console.ReadLine();
            Queue<string> customerQueue = new Queue<string>();

            while (customer != "End")
            {

                if (customer != "Paid" && customer != "End")
                {
                    customerQueue.Enqueue(customer);
                }

                if (customer == "Paid")
                {
                    for (int i = customerQueue.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(customerQueue.Dequeue());
                    }
                }

                customer = Console.ReadLine();
            }

            Console.WriteLine($"{customerQueue.Count} people remaining.");
        }
    }
}
