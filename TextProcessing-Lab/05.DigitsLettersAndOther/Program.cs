using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var others = new StringBuilder();

            for (int i = 0; i < imput.Length; i++)
            {
                var currentChar = imput[i];

                if (char.IsDigit(currentChar))
                {
                    nums.Append(currentChar);
                }
                else if (char.IsLetter(currentChar))
                {
                    letters.Append(currentChar);
                }
                else
                {
                    others.Append(currentChar);
                }
            }

            Console.WriteLine($"{nums}\n{letters}\n{others}");
        }
    }
}
