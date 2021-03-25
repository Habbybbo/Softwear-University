using System;

namespace _03.CharactersInRange
{
    class Program
    {

        static void PrintsCharactersInRange(char char1, char char2)
        {
            if (char1 < char2)
            {
                for (int i = char1 + 1; i < char2; i++)
                {
                    Console.Write((char)i + " ");
                }

            }
            else if (char1 > char2)
            {
                for (int i = char2 + 1; i < char1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }


        static void Main(string[] args)
        {

            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            
            PrintsCharactersInRange(char1, char2);
        }
    }
}
