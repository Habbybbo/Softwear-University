using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public string Type { get; set; }

        public Hen(string type, string name, double weight, double wingSize)
        {
            this.Type = type;
            base.Name = name;
            base.Weight = weight;
            base.WingSize = wingSize;
        }
        public void FeedMe()
        {
            Console.WriteLine("Cluck");
        }

        public override string ToString()
        {
            return $"{this.Type} [{base.Name}, {base.WingSize}, {base.Weight}, {base.FoodEaten}]";
        }
    }
}
