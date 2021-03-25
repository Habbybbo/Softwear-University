using System;

namespace _08.MathPower
{
    class Program
    {
        static double NumberMathPower(double num1, int num2)
        {
            double result = 0d;
            result = Math.Pow(num1, num2);
            return result;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double sum = NumberMathPower(num1, num2);
            Console.WriteLine(sum);
        }
    }
}
