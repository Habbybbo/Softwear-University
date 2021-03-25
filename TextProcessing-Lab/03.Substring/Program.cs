using System;
using System.Text;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string wordToCorrect = Console.ReadLine().ToLower();

            int index = wordToCorrect.IndexOf(wordToRemove);

            while (index != -1)
            {
                wordToCorrect = wordToCorrect.Remove(index, wordToRemove.Length);
                index = wordToCorrect.IndexOf(wordToRemove);
            }

            Console.WriteLine(wordToCorrect);



            
        }
    }
}
