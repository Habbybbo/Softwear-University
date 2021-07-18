using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Interfaces
{
    public interface ILieutenantGeneral
    {
        public ICollection<IPrivate> Privates { get; }
    }
}
