using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public string Type { get; set; }
        public Cat(string type, string name, double weight, string livingRegion, string breed)
        {
            this.Type = type;
            base.Name = name;
            base.Weight = weight;
            base.LivingRegion = livingRegion;
            base.Breed = breed;
        }
        public void FeedMe()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"{this.Type} [{base.Name}, {base.Breed}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
