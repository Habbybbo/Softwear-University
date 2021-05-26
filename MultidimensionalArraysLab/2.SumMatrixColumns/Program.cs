using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();

            int rows = sizes[0];
            int col = sizes[1];

            int[,] matrix = new int[rows, col];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse).ToArray();

                for (int j = 0; j < col; j++)
                {

                    int currentIndex = input[j];

                    matrix[i, j] = currentIndex;
                }
            }

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int currentIndex = matrix[j, i];
                    sum += currentIndex;
                }

                Console.WriteLine(sum);

                sum = 0;
            }
        }
    }
}
