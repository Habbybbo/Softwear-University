using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Interfaces
{
    public interface ICommando
    {
        public ICollection<IMission> Missions { get; }
    }
}
