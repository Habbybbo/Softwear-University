using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenSum += nums[i];
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] % 2 == 1)
                {
                    oddSum += nums[j];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
