using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public string Type { get; set; }

        public Paladin(string name, string type)
        {
            this.Type = type;
            base.Name = name;
        }

        public override void CastAbility()
        {
            base.Power = 100;
            Console.WriteLine($"{this.Type} - {base.Name} healed for {this.Power}");
        }
    }
}
