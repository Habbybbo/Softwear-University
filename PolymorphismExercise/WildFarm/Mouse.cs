using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public string Type { get; set; }

        public Mouse(string type, string name, double weight, string livingRegion)
        {
            this.Type = type;
            base.Name = name;
            base.Weight = weight;
            base.LivingRegion = livingRegion;
        }
        public void FeedMe()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return $"{this.Type} [{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
