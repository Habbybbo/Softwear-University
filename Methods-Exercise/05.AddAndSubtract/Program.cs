using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }


        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int total = Sum(num1, num2);

            int sum = Substract(total, num3);

            Console.WriteLine(sum);
        }
    }
}
