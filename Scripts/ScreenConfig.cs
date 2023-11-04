using System;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Config/Screens")]
    public class ScreenConfig : ScriptableObject
    {
        [SerializeField]
        public List<Screen> ScreenPrefabs = new List<Screen>();
    }
}