using _7.Enumerations;
using _7.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Models
{
    public class Commando : SpecialisedSoldier, ICommando

    {
        public Commando(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IMission> missions) 
            : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = missions;
        }

        public ICollection<IMission> Missions { get; }

        
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Missions:");

            foreach (var mission in Missions)
            {
                builder.AppendLine(mission.ToString());
            }
            
            return builder.ToString().TrimEnd();
        }
    }
}
