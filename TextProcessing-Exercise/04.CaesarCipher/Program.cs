using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();

            StringBuilder cypheredText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int textCharNum = text[i];
                textCharNum = textCharNum + 3;
                char textChar = (char)textCharNum;
                cypheredText.Append(textChar);
            }

            Console.WriteLine(cypheredText);
        }
    }
}
