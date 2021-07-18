using System;
using System.Collections.Generic;
using System.Linq;
using _7.Enumerations;
using _7.Interfaces;
using _7.Models;

namespace _7
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> result = new List<ISoldier>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string soldierType = inputTokens[0];
                int id = int.Parse(inputTokens[1]);
                string firstName = inputTokens[2];
                string lastName = inputTokens[3];

                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(inputTokens[4]);

                    result.Add(new Private(id, firstName, lastName, salary));
                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(inputTokens[4]);
                    result.Add(new Spy(id, firstName, lastName, codeNumber));
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputTokens[4]);

                    List<IPrivate> privates = new List<IPrivate>();

                    foreach (var currentId in inputTokens[5..])
                    {
                        IPrivate currentPrivate = (IPrivate)result.FirstOrDefault(x => x.Id == int.Parse(currentId));
                        privates.Add(currentPrivate);
                    }

                    result.Add(new LieutenantGeneral(id, firstName, lastName, salary, privates));
                }
                else if (soldierType == "Engineer")

                {
                    decimal salary = decimal.Parse(inputTokens[4]);
                    Enum.TryParse(inputTokens[5], out SoldierCorpEnum corp);
                    if (corp == default)
                    {
                        continue;
                    }

                    List<IRepair> repairs = new List<IRepair>();

                    for (int i = inputTokens[6..].Length + 2; i < inputTokens.Length; i+=2)
                    {
                        var partName = inputTokens[i];
                        var workedHours = int.Parse(inputTokens[i + 1]);

                        repairs.Add(new Repair(partName, workedHours));
                    }

                    result.Add(new Engineer(id, firstName, lastName, salary, corp, repairs));
                }
                else
                {
                    decimal salary = decimal.Parse(inputTokens[4]);
                    Enum.TryParse(inputTokens[5], out SoldierCorpEnum corp);
                    if (corp == default)
                    {
                        continue;
                    }

                    List<IMission> missions = new List<IMission>();

                    for (int i = inputTokens[6..].Length + 2; i < inputTokens.Length - 1; i++)
                    {
                        var missionState = inputTokens[i + 1];
                        if (missionState != "inProgress" && missionState != "finished")
                        {
                            continue;
                        }

                        string missionName = inputTokens[i];
                        Enum.TryParse(missionState, false, out MissionStateEnum state);
                        if (state != default)
                        {
                            IMission mission = new Mission(missionName, state);
                            missions.Add(mission);
                        }
                        
                    }

                    result.Add(new Commando(id, firstName, lastName, salary, corp, missions));
                }
            }


            foreach (var soldier in result)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
