using System;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] imput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<char> charList = new List<char>();

            for (int i = 0; i < imput.Length; i++)
            {
                var text = imput[i].ToCharArray();
                charList.AddRange(text);
                
            }


            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var character in charList)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }

                else
                {
                    charCount.Add(character, 1);
                }
            }

            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


            

        }
    }
}
