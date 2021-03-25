using System;
using System.Text;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string imput = Console.ReadLine();

                if (imput == "end")
                {
                    break;
                }

                string reversed = "";

                for (int i = imput.Length - 1; i >= 0; i--)
                {
                    reversed += imput[i];
                }

                Console.WriteLine($"{imput} = {reversed}");
            }
        }
    }
}
