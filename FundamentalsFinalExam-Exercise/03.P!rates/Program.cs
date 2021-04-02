using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> citiesToPlunder = new Dictionary<string, int[]>();

            string imput = Console.ReadLine();

            while (imput != "Sail")
            {
                string[] listToPlunder = imput.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int citizens = int.Parse(listToPlunder[1]);
                int citieGold = int.Parse(listToPlunder[2]);
                var townsName = listToPlunder[0];

                int[] citieNumbers = new int[] {citizens, citieGold };


                if (citiesToPlunder.ContainsKey(listToPlunder[0]))
                {
                    var peopleInTown = citiesToPlunder[townsName].GetValue(0).ToString();
                    var peopleResult = int.Parse(peopleInTown) + citizens;
                    citiesToPlunder[townsName].SetValue(peopleResult, 0);

                    var goldInTown = citiesToPlunder[townsName].GetValue(1).ToString();
                    var goldResult = int.Parse(goldInTown) + citieGold;
                    citiesToPlunder[townsName].SetValue(goldResult, 1);

                }

                else
                {
                    citiesToPlunder.Add(listToPlunder[0], citieNumbers);
                }


                imput = Console.ReadLine();
            }

            string commandImput = Console.ReadLine();

            while (commandImput != "End")
            {
                string[] tokens = commandImput.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Plunder":
                        string town = tokens[1];
                        int people = int.Parse(tokens[2]);
                        int gold = int.Parse(tokens[3]);

                        var peopleInTown = citiesToPlunder[town].GetValue(0);
                        var peopleInTownString = peopleInTown.ToString();
                        var peopleKilled = int.Parse(peopleInTownString) - people;
                        citiesToPlunder[town].SetValue(peopleKilled, 0);

                        var goldInTown = citiesToPlunder[town].GetValue(1);
                        var goldInTownToString = goldInTown.ToString();
                        var goldPlundered = int.Parse(goldInTownToString) - gold;
                        citiesToPlunder[town].SetValue(goldPlundered, 1);

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        var peopleResult = citiesToPlunder[town].GetValue(0).ToString();
                        var goldResult = citiesToPlunder[town].GetValue(1).ToString();

                        if (int.Parse(peopleResult) <= 0 || int.Parse(goldResult) <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            citiesToPlunder.Remove(town);
                        }

                        break;

                    case "Prosper":
                        string townToProsper = tokens[1];
                        int townsGold = int.Parse(tokens[2]);

                        if (townsGold <= 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            break;
                        }

                        var goldInTownToProsper = citiesToPlunder[townToProsper].GetValue(1);
                        var goldInTownToProsperToString = goldInTownToProsper.ToString();
                        var goldAdded = int.Parse(goldInTownToProsperToString) + townsGold;
                        citiesToPlunder[townToProsper].SetValue(goldAdded, 1);

                        Console.WriteLine($"{townsGold} gold added to the city treasury. {townToProsper} now has {goldAdded} gold.");

                        break;

                }

                commandImput = Console.ReadLine();
            }

            var result = citiesToPlunder.OrderByDescending(x => x.Value[1]).ThenBy(k => k.Key);

            if (citiesToPlunder.Count <= 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesToPlunder.Count} wealthy settlements to go to:");

                foreach (var city in result)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }

            
        }
    }
}
