using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {

        static void ReturnSmallestNumber(int num1, int num2, int num3)
        {
            int smallestNumber = Math.Min(num3, Math.Min(num1, num2));

            Console.WriteLine(smallestNumber);
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            ReturnSmallestNumber(num1, num2, num3);
        }
    }
}
