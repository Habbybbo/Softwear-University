using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> raid = new List<BaseHero>();

            int heroesNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < heroesNum; i++)
            {
                string playerName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid" || heroType == "Paladin" || heroType == "Warrior" || heroType == "Rogue")
                {
                    switch (heroType)
                    {
                        case "Druid":
                            Druid druid = new Druid(playerName, heroType);
                            raid.Add(druid);
                            break;
                        case "Paladin":
                            Paladin paladin = new Paladin(playerName, heroType);
                            raid.Add(paladin);
                            break;
                        case "Warrior":
                            Warrior warrior = new Warrior(playerName, heroType);
                            raid.Add(warrior);
                            break;
                        case "Rogue":
                            Rogue rogue = new Rogue(playerName, heroType);
                            raid.Add(rogue);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int tottalHeroPower = 0;

            foreach (var hero in raid)
            {
                hero.CastAbility();
                tottalHeroPower += hero.Power;
            }

            
            if (tottalHeroPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
