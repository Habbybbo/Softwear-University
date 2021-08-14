using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int comfort;
        public string Name 
        { get
            {
                return name;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }

                this.name = value;
            } 
        }

        public int Capacity { get; set; }

        public int Comfort 
        {
            get 
            {
                return comfort;
            }
            set
            {
                this.comfort = value;
            } 
        }
        

        public ICollection<IDecoration> Decorations { get; set; }

        public ICollection<IFish> Fish { get; set; }

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public void AddDecoration(IDecoration decoration)
        {
            Decorations.Add(decoration);

            this.Comfort += decoration.Comfort;
        }

        public void AddFish(IFish fish)
        {
            if (Fish.Count >= Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            Fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in Fish)
            {
                fish.Eat();
            }
        }

        public virtual string GetInfo()
        {
            throw new NotImplementedException();
        }

        public bool RemoveFish(IFish fish)
        {
            bool fishRemoved = false;
            if (Fish.Remove(fish))
            {
                fishRemoved = true;
            }

            return fishRemoved;
        }
    }
}
