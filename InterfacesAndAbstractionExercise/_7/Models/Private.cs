using System;
using System.Collections.Generic;
using System.Text;
using _7.Interfaces;

namespace _7.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Math.Round(this.Salary, 2):F2}";
        }
    }
}
