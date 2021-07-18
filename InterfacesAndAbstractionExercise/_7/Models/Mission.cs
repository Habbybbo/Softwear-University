using System;
using System.Collections.Generic;
using System.Text;
using _7.Enumerations;
using _7.Interfaces;

namespace _7.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionStateEnum missionState)
        {
            CodeName = codeName;
            MissionState = missionState;
        }

        public string CodeName { get; }

        public MissionStateEnum MissionState { get; private set; }

        public void CompleteMission()
        {
            this.MissionState = MissionStateEnum.Finished;
        }

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {MissionState}";
        }
    }
}
