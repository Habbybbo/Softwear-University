using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, string> firstTuple = new MyTuple<string, string>(firstTupleData[0] + " " + firstTupleData[1], firstTupleData[2]);

            string[] secondTupleData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(secondTupleData[0], int.Parse(secondTupleData[1]));

            string[] thirdTupleData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            MyTuple<int, double> thirdTuple = new MyTuple<int, double>(int.Parse(thirdTupleData[0]), double.Parse(thirdTupleData[1]));

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
