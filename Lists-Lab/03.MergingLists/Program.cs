using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> resultList = new List<int>(list1.Count + list2.Count);
            int limit = Math.Min(list1.Count, list2.Count);

            for (int i = 0; i < limit; i++)
            {
                resultList.Add(list1[i]);
                resultList.Add(list2[i]);
            }

            if (list1.Count != list2.Count)
            {
                if (list1.Count > list2.Count)
                {
                    resultList.AddRange(GetRemainingList(list1, list2));
                }
                else
                {
                    resultList.AddRange(GetRemainingList(list2, list1));
                }
            }

            Console.WriteLine(string.Join(" ", resultList));

            


        }

        private static List<int> GetRemainingList(List<int> longerList, List<int> shorterList)
        {
            if (longerList.Count <= shorterList.Count)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            return result;
        }

    }
}
