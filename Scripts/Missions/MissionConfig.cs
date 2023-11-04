using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Missions/MissionConfig")]
    public class MissionConfig : ScriptableObject
    {
        public string MissionName;
        [Multiline]
        public string MissionDescription;
        public int WavesAvailable;
    }
}