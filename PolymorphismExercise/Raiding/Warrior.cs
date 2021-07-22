using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public string Type { get; set; }

        public Warrior(string name, string type)
        {
            this.Type = type;
            base.Name = name;
        }

        public override void CastAbility()
        {
            base.Power = 100;
            Console.WriteLine($"{this.Type} - {base.Name} hit for {this.Power} damage");
        }
    }
}
