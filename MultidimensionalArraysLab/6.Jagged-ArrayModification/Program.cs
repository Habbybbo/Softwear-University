using System;
using System.Linq;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jaged[i] = ReadArrayFromConsole();
            }

            string command = Console.ReadLine()?.ToUpper();

            while (command != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= n || col < 0 || col >= jaged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine()?.ToUpper();
                    continue;
                }

                switch (tokens[0])
                {
                    case "ADD":
                        jaged[row][col] += value;
                        break;
                    case "SUBTRACT":
                        jaged[row][col] -= value;
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine()?.ToUpper();

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(' ', jaged[i]));
            }
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        }
    }
}
