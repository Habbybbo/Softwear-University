using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var imput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string imput1 = imput[0];
            string imput2 = imput[1];

            int output = TottalSumOfCharacters(imput1, imput2);

            Console.WriteLine(output);
        }

        static int TottalSumOfCharacters(string string1, string string2)
        {
            int sum = 0;
            string longest = string.Empty;
            string shortest = string.Empty;

            if (string1.Length < string2.Length)
            {
                shortest = string1;
                longest = string2;

                for (int i = 0; i < shortest.Length; i++)
                {
                    sum += shortest[i] * longest[i];
                }

                for (int i = longest.Length - 1; i > 0; i--)
                {
                    sum += longest[i];
                }
            }

            else
            {
                shortest = string2;
                longest = string1;

                for (int i = 0; i < longest.Length; i++)
                {
                    sum += shortest[i] * longest[i];
                }

            }



            return sum;
        }
    }
}
