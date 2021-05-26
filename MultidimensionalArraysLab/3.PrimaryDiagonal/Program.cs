using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            int sum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    int currentIndex = input[j];

                    matrix[i, j] = currentIndex;

                    if (i == j)
                    {
                        sum += currentIndex;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
