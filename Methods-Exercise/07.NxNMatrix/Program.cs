using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void PrintsNxNMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintsNxNMatrix(num);

            
        }
    }
}
