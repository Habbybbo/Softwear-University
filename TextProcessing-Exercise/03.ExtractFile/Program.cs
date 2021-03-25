using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var imput = Console.ReadLine()
                .Split('\\', StringSplitOptions.RemoveEmptyEntries);

            List<string> file = imput[3].Split('.').ToList();

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
            
            
        }
    }
}
