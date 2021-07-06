﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double cakeGrams = 250;
        private const double cakeCalories = 1000;
        private const decimal CakePrice = 5m;
        public Cake(string name) 
            : base(name, CakePrice, cakeGrams, cakeCalories)
        {
        }
    }
}
