using System;
using System.Collections.Generic;
using System.Text;
using _7.Enumerations;

namespace _7.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; }

        public MissionStateEnum MissionState { get; }

        public void CompleteMission();
    }
}
