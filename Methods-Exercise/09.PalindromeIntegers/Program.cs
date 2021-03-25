using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            string reverstString = string.Empty;

            while (true)
            {
                string imputString = Console.ReadLine();

                reverstString = string.Empty;

                if (imputString == "END")
                {
                    break;
                }

                for (int i = imputString.Length - 1; i >= 0; i--)
                {
                    reverstString += imputString[i];
                }

                

                if (reverstString == imputString)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
        }
    }
}
