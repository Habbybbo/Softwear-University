using System;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];
            string snakeName = Console.ReadLine();

            char[,] matrix = new char[rows, cols];
            int currentLetter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;

                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;

                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
                
            }

            printMatrix(matrix);
        }

        private static void printMatrix(char[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void fillMatrix(string[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                string[] currenrRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currenrRow[col];
                }

            }
        }
    }
}
