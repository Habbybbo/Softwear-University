using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int power = 0;

            for (int i = 0; i < imput.Length; i++)
            {
                char current = imput[i];

                if (current == '>')
                {
                    power += int.Parse(imput[i + 1].ToString());
                    sb.Append(current);
                }
                else if (power == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    power--;
                }

            }

            Console.WriteLine(sb);
        }
    }
}
