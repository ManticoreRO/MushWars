using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Ships/EntityData")]
    public class EntitiesData : ScriptableObject
    {
        public List<MushroomConfig> Mushrooms;
        public List<EnemyConfig> Enemies;
    }
}