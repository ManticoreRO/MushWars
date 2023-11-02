using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Ships/Mushrooms")]
    public class MushroomConfig : ScriptableObject
    {
        public GeneralStats Stats;
        public Sprite Appearance;
        public int MissionFirstAppearance;
        public int BaseSpawnCost;        
    }
}