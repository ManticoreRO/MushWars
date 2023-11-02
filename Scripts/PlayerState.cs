using System;
using System.Collections;
using System.Collections.Generic;

namespace QDS.MushWars
{    
    [Serializable]
    public class PlayerState
    {
        public int CurrentMission;
        public int CurrentSpores;//aka gold
        public List<int> UnlockedMushes;
    }
}