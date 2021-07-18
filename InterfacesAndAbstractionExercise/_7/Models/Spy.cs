using System;
using System.Collections.Generic;
using System.Text;
using _7.Interfaces;

namespace _7.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .Append($"Code Number: {CodeNumber}");

            return builder.ToString();
        }
    }
}
