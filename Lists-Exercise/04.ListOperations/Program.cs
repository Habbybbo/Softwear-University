using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string imput = Console.ReadLine();

                if (imput == "End")
                {
                    break;
                }

                string[] operations = imput.Split();

                if (operations[0] == "Add")
                {
                    int operationNumber = int.Parse(operations[1]);
                    numbers.Add(operationNumber);
                }

                if (operations[0] == "Insert")
                {
                    int operationNumber = int.Parse(operations[1]);
                    int operationIndex = int.Parse(operations[2]);

                    if (operationIndex >= 0 && operationIndex < numbers.Count)
                    {
                        numbers.Insert(operationIndex, operationNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }

                if (operations[0] == "Remove")
                {
                    int operationIndex = int.Parse(operations[1]);

                    if (operationIndex >= 0 && operationIndex < numbers.Count)
                    {
                        numbers.RemoveAt(operationIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }

                if (operations[0] == "Shift" && operations[1] == "left")
                {
                    int operationCount = int.Parse(operations[2]);

                    for (int i = 0; i < operationCount; i++)
                    {
                        int furstNum = numbers[0];
                        numbers.Add(furstNum);
                        numbers.RemoveAt(0);
                    }
                }
                else if (operations[0] == "Shift" && operations[1] == "right")
                {
                    int operationCount = int.Parse(operations[2]);

                    for (int i = 0; i < operationCount; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];
                        numbers.Insert(0, lastNum);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
