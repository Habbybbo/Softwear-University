using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; } = 0;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;

        }

        public void BuyFood()
        {
            this.Food = 10;
        }
    }
}
