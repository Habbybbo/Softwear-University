using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public string Type { get; set; }

        public Rogue(string name, string type)
        {
            this.Type = type;
            base.Name = name;
        }

        public override void CastAbility()
        {
            base.Power = 80;
            Console.WriteLine($"{this.Type} - {base.Name} hit for {this.Power} damage");
        }
    }
}
