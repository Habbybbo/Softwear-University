using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            int matrixCounter = 0;

            for (int row = 0; row < size[0]; row++)
            {

                char[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = input[col];
                }

            }

            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        matrixCounter++;
                    }
                }
            }

            Console.WriteLine(matrixCounter);
        }
    }
}
