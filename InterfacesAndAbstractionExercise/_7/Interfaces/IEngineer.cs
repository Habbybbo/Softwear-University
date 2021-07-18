using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Interfaces
{
    public interface IEngineer
    {
        public ICollection<IRepair> Repairs { get; }
    }
}
