using CommandPattern.Core.Models.Commands;
using System;

namespace CommandPattern.Core.Contracts
{
    public interface ICommandInterpreter
    {
        public string Read(string args);
        
    }
}
