using System;

namespace _07.RepeatString
{
    class Program
    {
        static void RepeatingString(string imput, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(imput);
            }
        }
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            RepeatingString(imput, repeat);
        }
    }
}
