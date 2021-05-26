using System;
using System.Linq;

namespace _1.SumMatrixElements
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
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse).ToArray();

                for (int j = 0; j < col; j++)
                {
                    
                    int currentIndex = input[j];

                    matrix[i, j] = currentIndex;
                    sum += currentIndex;
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(col);
            Console.WriteLine(sum);
            


        }

    }
}
