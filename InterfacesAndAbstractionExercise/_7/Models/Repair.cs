using System;
using System.Collections.Generic;
using System.Text;
using _7.Interfaces;

namespace _7.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; }

        public int HoursWorked { get; }

        public override string ToString()
        {
            return $"  Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
