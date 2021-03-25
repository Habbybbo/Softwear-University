using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            BigInteger num1Sum = 1;
            BigInteger num2Sum = 1;

            for (int i = num1; i > 0; i--)
            {
                num1Sum *= i;
            }

            for (int j = num2; j > 0; j--)
            {
                num2Sum *= j;
            }

            BigInteger totalSum = num1Sum / num2Sum;

            Console.WriteLine($"{totalSum:F2}");

        }
    }
}
