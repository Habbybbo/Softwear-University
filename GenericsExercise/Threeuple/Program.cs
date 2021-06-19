using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            string city = string.Empty;

            if (firstTupleData.Length > 4)
            {
                city = $"{firstTupleData[3]} {firstTupleData[4]}";
            }
            else
            {
                city = $"{firstTupleData[3]}";
            }


            MyTuple<string, string, string> firstTuple = new MyTuple<string, string, string>
                (fullName, firstTupleData[2], city);

            string[] secondTupleData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            bool drunk = false;

            if (secondTupleData[2] == "drunk")
            {
                drunk = true;
            }
            else if (secondTupleData[2] == "not")
            {
                drunk = false;
            }

            MyTuple<string, int, bool> secondTuple = new MyTuple<string, int, bool>(secondTupleData[0], int.Parse(secondTupleData[1]), drunk);

            string[] thirdTupleData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, double, string> thirdTuple = new MyTuple<string, double, string>(thirdTupleData[0], double.Parse(thirdTupleData[1]), thirdTupleData[2]);

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
