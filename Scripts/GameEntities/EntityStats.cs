using System;
using UnityEngine;

namespace QDS.MushWars
{
    [Serializable]
    public class EntityStats
    {
        public string name;
        [Multiline]
        public string description;
        public int hp;
        public int armor;
        public int speed;
    }
}