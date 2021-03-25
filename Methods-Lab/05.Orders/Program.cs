using System;

namespace _05.Orders
{
    class Program
    {

        static void Products(string product, int quantity)
        {
            double sum = 0;
            double price = 0;

            if (product == "coffee")
            {
                price = 1.50;
                sum = price * quantity;
            }
            else if (product == "water")
            {
                price = 1.00;
                sum = price * quantity;
            }
            else if (product == "coke")
            {
                price = 1.40;
                sum = price * quantity;
            }
            else if (product == "snacks")
            {
                price = 2.00;
                sum = price * quantity;
            }

            Console.WriteLine($"{sum:F2}");
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Products(product, quantity);
        }
    }
}
