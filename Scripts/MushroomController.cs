using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public class MushroomController : MonoBehaviour
    {
        private SpriteRenderer mushVisual;
        private MushroomConfig _config;
        private GeneralStats _currentStats;

        private void Start()
        {
            mushVisual = GetComponentInChildren<SpriteRenderer>();
        }

        public void Setup(MushroomConfig config)
        {
            _config = config;
            _currentStats = _config.Stats;
            mushVisual.sprite = _config.Appearance;
        }
    }
}