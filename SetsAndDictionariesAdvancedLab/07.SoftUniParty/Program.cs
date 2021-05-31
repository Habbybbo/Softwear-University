using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipQuests = new HashSet<string>();
            HashSet<string> regularQuests = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "PARTY")
            {

                if (Char.IsDigit(command, 0))
                {
                    vipQuests.Add(command);
                }
                else
                {
                    regularQuests.Add(command);
                }
            }

            while ((command = Console.ReadLine()) != "END")
            {
                if (Char.IsDigit(command, 0))
                {
                    vipQuests.Remove(command);
                }
                else
                {
                    regularQuests.Remove(command);
                }
            }

            Console.WriteLine(vipQuests.Count + regularQuests.Count);

            foreach (var quest in vipQuests)
            {
                Console.WriteLine(quest);
            }

            foreach (var quest in regularQuests)
            {
                Console.WriteLine(quest);
            }
        }
    }
}
