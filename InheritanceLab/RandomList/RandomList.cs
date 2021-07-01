using System.Collections.Generic;
using System.Linq;
using System;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public Random Rnd { get; set; }

        public RandomList(Random rnd)
        {
            this.Rnd = rnd;
        }

        public string RemoveRandomElement()
        {
            int index = Rnd.Next(0, this.Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;

        }
    }
}
