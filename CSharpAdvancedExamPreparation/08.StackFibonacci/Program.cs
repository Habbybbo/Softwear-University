using System;
using System.Collections.Generic;

namespace _08.StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Stack<long> fibonaciNums = new Stack<long>();

            fibonaciNums.Push(0);
            fibonaciNums.Push(1);
            

            //0, 1, 1, 2, 3, 5, 8

            for (int i = 0; i < input; i++)
            {
                long topNum = fibonaciNums.Pop();
                long previouseNum = fibonaciNums.Pop();
                long nextNum = topNum + previouseNum;

                fibonaciNums.Push(topNum);
                fibonaciNums.Push(nextNum);
            }

            fibonaciNums.Pop();

            Console.WriteLine(fibonaciNums.Peek());


        }
    }
}
