using System;
using System.Text;
using System.Linq;
namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToList();

            for (int i = 0; i < str.Count - 1; i++)
            {
                char cuur = str[i];
                char next = str[i + 1];

                if (cuur == next)
                {
                    str.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", str));
        }
    }
}
