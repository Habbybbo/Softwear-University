using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] sum = new int[] { num1, num2, num3 };

            Array.Sort(sum);

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sum[i]);
            }






        }
    }
}
