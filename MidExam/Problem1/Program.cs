using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperiance = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());

            double experianceSum = 0;
            int battleSum = 1;
            

            for (int i = 1; i <= battlesCount; i++)
            {
                double experiancePerBattle = double.Parse(Console.ReadLine());

                experianceSum += experiancePerBattle;
                if (i % 3 == 0)
                {
                    experianceSum += experiancePerBattle * 0.15;
                }

                if (i % 5 == 0)
                {
                    experianceSum -= experiancePerBattle * 0.10;
                }

                if (i % 15 == 0)
                {
                    experianceSum += experiancePerBattle + (experiancePerBattle * 0.05);
                }

                if (experianceSum >= neededExperiance)
                {
                    break;
                }

                battleSum++;

            }

            

            if (experianceSum >= neededExperiance)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleSum} battles.");
            }
            else
            {

                double experienceLeft = neededExperiance - experianceSum;
                Console.WriteLine($"Player was not able to collect the needed experience, {experienceLeft:F2} more needed.");
            }
        }
    }
}
