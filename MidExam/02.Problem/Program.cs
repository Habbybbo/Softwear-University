using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] imputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> imputList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "end")
                {
                    break;
                }

                string[] imputCommand = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (imputCommand[0] == "reverse")
                {
                    int start = int.Parse(imputCommand[2]);
                    int count = int.Parse(imputCommand[4]);

                    imputList.Reverse(start, count);
                }

                if (imputCommand[0] == "remove")
                {
                    
                    int count = int.Parse(imputCommand[1]);

                    imputList.RemoveRange(0, count);
                }
            }

            Console.WriteLine(string.Join(", ", imputList));
        }
    }
}
