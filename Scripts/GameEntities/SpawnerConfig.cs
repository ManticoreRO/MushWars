using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

namespace QDS.MushWars
{
    [CreateAssetMenu(menuName = "Entities/SpawnerConfig")]
    public class SpawnerConfig : ScriptableObject
    {
        public List<GameObject> Prefabs;
        public List<EntityConfig> Entities;         
    }
}