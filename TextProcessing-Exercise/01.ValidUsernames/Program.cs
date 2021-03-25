using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var imput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var validUserNames = new List<string>();

            for (int i = 0; i < imput.Length; i++)
            {
                string currentString = imput[i];

                if (currentString.Length >= 3 && currentString.Length <= 16)
                {
                    bool isValid = true;

                    for (int j = 0; j < currentString.Length; j++)
                    {

                        if (!(char.IsLetterOrDigit(currentString[j]) || currentString[j] == '-' || currentString[j] == '_'))
                        {
                            isValid = false;
                        }

                    }

                    if (isValid)
                    {
                        validUserNames.Add(currentString);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }
    }
}
