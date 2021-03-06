using System;

namespace Person
{
    public class Child : Person
    {
        public override int Age 
        {
            get 
            {
                return base.Age;
            }
            set 
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child age cannot be greater than 15");
                }

                base.Age = value;
            } 
        }
        public Child(string name, int age)
            : base(name, age)
        {
        }
    }
}
