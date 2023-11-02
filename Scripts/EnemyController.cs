using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{    
    public class EnemyController : MonoBehaviour
    {
        private SpriteRenderer visual;
        private EnemyConfig _config;
        private GeneralStats _currentStats;

        private void Start()
        {
            visual = GetComponentInChildren<SpriteRenderer>();
        }

        public void Setup(EnemyConfig config)
        {
            _config = config;
            _currentStats = _config.Stats;
            visual.sprite = _config.Appearance;
        }
    }
}