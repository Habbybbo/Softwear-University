using System;
using System.Collections.Generic;
using System.Text;
using _7.Enumerations;
using _7.Interfaces;

namespace _7.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp) 
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public SoldierCorpEnum Corp { get; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine($"Corps: {Corp}");

            return builder.ToString().TrimEnd();
        }
    }
}
