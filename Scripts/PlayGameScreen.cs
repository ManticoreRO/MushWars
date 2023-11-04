using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public class PlayGameScreen : Screen
    {
        [SerializeField] private Transform mushSpawnerParent;
        [SerializeField] private Transform enemySpawnerParent;
        [SerializeField] private Transform mushParent;
        [SerializeField] private Transform enemyParent;
        [SerializeField] private Transform projectileParent;
        [SerializeField] private List<Transform> mushSpawners;
        [SerializeField] private List<Transform> enemySpawners;
        [SerializeField] private GameObject MushPrefab;
        [SerializeField] private GameObject EnemyPrefab;

        public void SpawnMush1()
        {            
        }
        
        public void SpawnEnemy()
        {           
        }

        void Start()
        {
            var height = new Vector3(0, Camera.main.orthographicSize + 1, 0);
            mushSpawnerParent.transform.position += height;
            enemySpawnerParent.transform.position -= height;
        }
        
        void Update()
        {

        }
    }
}