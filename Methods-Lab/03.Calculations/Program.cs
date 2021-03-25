using System;

namespace _03.Calculations
{
    class Program
    {

        static void Add(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine(sum);
        
        }

        static void Multyply(int first, int second)
        {
            int sum = first * second;
            Console.WriteLine(sum);

        }

        static void Subtract(int first, int second)
        {
            int sum = first - second;
            Console.WriteLine(sum);
        }

        static void Divide(int first, int second)
        {
            int sum = first / second;
            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            string method = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (method == "add")
            {
                Add(firstNum, secondNum);
            }
            else if (method == "multiply")
            {
                Multyply(firstNum, secondNum);
            }
            else if (method == "subtract")
            {
                Subtract(firstNum, secondNum);
            }
            else if (method == "divide")
            {
                Divide(firstNum, secondNum);
            }
        }
    }
}
