using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "IN")
                {
                    parkingLot.Add(tokens[1]);
                }
                else if (tokens[0] == "OUT")
                {
                    parkingLot.Remove(tokens[1]);
                }
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
