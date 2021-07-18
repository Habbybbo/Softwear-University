using System;
using System.Collections.Generic;
using System.Text;
using _7.Enumerations;
using _7.Interfaces;

namespace _7.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corp)
        {
            this.Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                builder.AppendLine(repair.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
