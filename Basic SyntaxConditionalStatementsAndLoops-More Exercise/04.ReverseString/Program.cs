using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            char[] imputChar = imput.ToCharArray();

            char[] reverse = imputChar.Reverse().ToArray();

            Console.WriteLine(reverse);
        }
    }
}
