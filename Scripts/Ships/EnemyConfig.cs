using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Ships/Enemy")]
    public class EnemyConfig : ScriptableObject
    {       
        public GeneralStats Stats;
        public Sprite Appearance;
        public int MissionFirstAppearance;
    }
}