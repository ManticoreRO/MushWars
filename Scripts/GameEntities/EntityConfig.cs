using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Entities/Entity")]
    public class EntityConfig : ScriptableObject
    {       
        public EntityTypes EntityType;
        public EntityStats Stats;
        public Sprite Appearance;
        public bool FlipVertically = false;
    }
}