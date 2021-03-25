using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 1; i <= guests; i++)
            {
                string person = Console.ReadLine();

                string[] personName = person.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (person == personName[0] + " is going!")
                {
                    if (guestList.Contains(personName[0]))
                    {
                        Console.WriteLine(personName[0] + " is already in the list!");
                    }
                    else
                    {
                        guestList.Add(personName[0]);
                    }
                }
                if (person == personName[0] + " is not going!")
                {
                    if (guestList.Contains(personName[0]))
                    {
                        guestList.Remove(personName[0]);
                    }
                    else
                    {
                        Console.WriteLine(personName[0] + " is not in the list!");
                    }
                }

            }

            foreach (string personName in guestList)
            {
                Console.WriteLine(personName);
            }

            
        }
    }
}
