using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, bool> filter = name => name.Length <= n;

            names = names.Where(filter).ToList();

            Action<List<string>> print = name => Console.WriteLine(string.Join(Environment.NewLine, name));

            print(names);

            
            

        }
    }
}
