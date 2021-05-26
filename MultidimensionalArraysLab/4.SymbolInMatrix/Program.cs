using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    char currentChar = input[j];

                    matrix[i, j] = currentChar;
                }
            }

            string charInput = Console.ReadLine();

            int row = 0;
            int col = 0;

            bool charFound = false;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    row = i;
                    col = j;

                    string currentChar = matrix[i, j].ToString();

                    if (currentChar == charInput)
                    {
                        Console.WriteLine($"({row}, {col})");
                        charFound = true;
                        break;
                    }
                }
            }

            if (charFound == false)
            {
                Console.WriteLine($"{charInput} does not occur in the matrix");
            }
            

        }
    }
}
