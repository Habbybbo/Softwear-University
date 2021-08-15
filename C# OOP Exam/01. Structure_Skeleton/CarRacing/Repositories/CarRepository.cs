using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        public IReadOnlyCollection<ICar> Models { get; set; }

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }

            List<ICar> tempCarList = new List<ICar>(Models);
            tempCarList.Add(model);
            Models = tempCarList;
        }

        public ICar FindBy(string property)
        {
            ICar carFound = null;
            foreach (var car in Models)
            {
                if (car.VIN == property)
                {
                    carFound = car;
                }
            }

            return carFound;

        }

        public bool Remove(ICar model)
        {
            bool removeSuccesful = false;
            List<ICar> tempCarList = new List<ICar>(Models);
            if (tempCarList.Remove(model))
            {
                removeSuccesful = true;
                Models = tempCarList;
            }

            return removeSuccesful;
        }
    }
}
