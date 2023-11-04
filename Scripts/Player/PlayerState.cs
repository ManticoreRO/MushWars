using System;
using System.Collections;
using System.Collections.Generic;

namespace QDS.MushWars
{
    [Serializable]
    public class MushroomData
    {
        public MushroomConfig Config;
        public bool Unlocked;
        public int Level;        
    }

    [Serializable]
    public sealed class PlayerState
    {
        public int CurrentMission;
        public int CurrentSpores;//aka gold
        public List<MushroomData> UnlockedMushes;

        public bool OptionSkipIntro = false;
        public int OptionSfxVolume = 10;
        public int OptionMusicVolume = 10;

        public PlayerState() 
        {
            CurrentMission = 0; 
            CurrentSpores = 20;
            UnlockedMushes = new List<MushroomData>();           
        }    
    }
}