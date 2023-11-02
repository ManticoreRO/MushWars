using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [Serializable]
    public class GeneralStats
    {
        public string name;
        [Multiline]
        public string description;
        public int hp;
        public int armor;
        public int speed;
    }
}