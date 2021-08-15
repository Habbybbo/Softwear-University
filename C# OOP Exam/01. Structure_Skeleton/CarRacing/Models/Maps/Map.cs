using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            
            double racerOneWinningChance = 0;
            double racerTwoWinningChance = 0;

            if (racerOne.RacingBehavior == "strict")
            {
                racerOneWinningChance = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
            }
            else if (racerOne.RacingBehavior == "aggressive")
            {
                racerOneWinningChance = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1;
            }

            if (racerTwo.RacingBehavior == "strict")
            {
                racerOneWinningChance = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
            }
            else if (racerTwo.RacingBehavior == "aggressive")
            {
                racerOneWinningChance = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1;
            }

            if (racerOneWinningChance > racerTwoWinningChance)
            {
                return string.Format(OutputMessages.RacerWinsRace, racerOne, racerTwo, racerOne);
            }
            else if (racerTwoWinningChance > racerOneWinningChance)
            {
                return string.Format(OutputMessages.RacerWinsRace, racerOne, racerTwo, racerTwo);
            }

            if (racerOne.IsAvailable() == false)
            {
                return string.Format(string.Format(OutputMessages.OneRacerIsNotAvailable, racerTwo, racerOne));
            }
            else if (racerTwo.IsAvailable() == false)
            {
                return string.Format(string.Format(OutputMessages.OneRacerIsNotAvailable, racerOne, racerTwo));
            }
            else
            {
                return string.Format(OutputMessages.RaceCannotBeCompleted);
            }
        }
    }
}
