using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        private string name;
        private string species;
        private decimal price;
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishName);
                }

                this.name = value;
            }
        }

        public string Species
        {
            get
            {
                return species;
            }
            protected set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishSpecies);
                }

                this.species = value;
            }
        }

        public int Size { get; set; }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishPrice);
                }
            }
        }

        public Fish(string name, string species, decimal price)
        {
            Name = name;
            Species = species;
            Price = price;
        }

        public virtual void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
