using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        public IReadOnlyCollection<IRacer> Models { get; set; }

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }

            List<IRacer> tempRacerList = new List<IRacer>(Models);
            tempRacerList.Add(model);
            Models = tempRacerList;
        }

        public IRacer FindBy(string property)
        {
            IRacer racerFound = null;
            foreach (var racer in Models)
            {
                if (racer.Username == property)
                {
                    racerFound = racer;
                }
            }

            return racerFound;
        }

        public bool Remove(IRacer racer)
        {
            bool removeSuccesful = false;
            List<IRacer> tempRacerList = new List<IRacer>(Models);
            if (tempRacerList.Remove(racer))
            {
                removeSuccesful = true;
                Models = tempRacerList;
            }

            return removeSuccesful;
        }
    }
}
