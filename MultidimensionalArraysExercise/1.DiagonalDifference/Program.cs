using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    int currentNum = input[col];

                    matrix[row, col] = currentNum;
                }

            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    int currentNum = matrix[row, col];

                    if (row == col)
                    {
                        primarySum += currentNum;
                    }

                    if (col == size - 1 - row)
                    {
                        secondarySum += currentNum;
                    }
                }
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));

            
        }
    }
}
