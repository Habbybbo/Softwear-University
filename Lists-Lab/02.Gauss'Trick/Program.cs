using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int originalLenght = nums.Count;

            for (int i = 0; i < originalLenght / 2; i++)
            {
                nums[i] += nums[nums.Count - 1];
                
                nums.RemoveAt(nums.Count - 1);
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
