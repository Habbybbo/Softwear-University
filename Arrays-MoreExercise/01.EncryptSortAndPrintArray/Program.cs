using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<int> sequenceList = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                string name = Console.ReadLine();
                int stringLenght = name.Length;
                int sum = 0;
                

                char[] charArray = name.ToCharArray();
                for (int j = 0; j < charArray.Length; j++)
                {
                    char character = charArray[j];
                    

                    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' 
                        || character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
                    {
                        int volwelNum = (int)character;
                        sum += volwelNum * stringLenght;
                    }

                    if (character == 'b' || character == 'c' || character == 'd' || character == 'f' || character == 'g' || character == 'h'
                        || character == 'j' || character == 'k' || character == 'l' || character == 'm' || character == 'n' || character == 'p'
                        || character == 'q' || character == 'r' || character == 's' || character == 't' || character == 'v' || character == 'w'
                        || character == 'x' || character == 'z' || character == 'y'
                        || character == 'B' || character == 'C' || character == 'D' || character == 'F' || character == 'G' || character == 'H'
                        || character == 'J' || character == 'K' || character == 'L' || character == 'M' || character == 'N' || character == 'P'
                        || character == 'Q' || character == 'R' || character == 'S' || character == 'T' || character == 'V' || character == 'W'
                        || character == 'X' || character == 'Z' || character == 'Y')
                    {
                        int consonantNum = (int)character;
                        sum += consonantNum / stringLenght;

                    }
                }

                sequenceList.Add(sum);
                

            }

            sequenceList.Sort();

            foreach (var item in sequenceList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
