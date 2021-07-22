using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public string Type { get; set; }

        public Dog(string type, string name, double weight, string livingRegion)
        {
            this.Type = type;
            base.Name = name;
            base.Weight = weight;
            base.LivingRegion = livingRegion;
        }
        public void FeedMe()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"{this.Type} [{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
