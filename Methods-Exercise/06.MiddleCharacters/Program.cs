using System;
using System.Linq;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void PrintsMiddleCharacter(string text)
        {
            int lenght = text.Length;
            string result = "";

            if (lenght % 2 == 1)
            {
                result = text[text.Length / 2].ToString();
                Console.WriteLine(result);
            }
            else
            {
                result = text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();
                Console.WriteLine(result);
            }
        }


        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            PrintsMiddleCharacter(imput);
        }
    }
}
