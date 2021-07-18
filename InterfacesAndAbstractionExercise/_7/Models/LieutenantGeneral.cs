using System;
using System.Collections.Generic;
using System.Text;
using _7.Interfaces;

namespace _7.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public ICollection<IPrivate> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString())
            .AppendLine("Privates:");

            foreach (var current in this.Privates)
            {
                sb.AppendLine("  " + current.ToString());
            }

            return sb.ToString().TrimEnd();

        }
    }
}
