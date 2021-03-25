using System;

namespace _02.VowelsCount
{
    class Program
    {

        static void VowelsCount(string text)
        {

            //A, E, I, O and U.Sometimes we count Y
            //string[] vowels = new string[6] {"a", "e", "i", "o", "u", "y"};
            int vowelsCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' 
                    || text[i] == 'u' || text[i] == 'y')
                {
                    vowelsCounter++;
                }
            }

            Console.WriteLine(vowelsCounter);
        }


        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            VowelsCount(text);
        }
    }
}
