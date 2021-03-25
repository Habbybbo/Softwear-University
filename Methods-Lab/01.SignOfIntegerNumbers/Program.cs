using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {

        static void SignOfNum(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        
        
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SignOfNum(n);
        }
    }
}
