using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            var randpos = Random.Range(0, mushSpawners.Count-1);
            _entitySystem.AddEntity(new EntitySpawnData(SpriteTypes.Sprout, mushSpawners[randpos].position));
        }
        
        public void SpawnEnemy()
        {           
        }

        void Start()
        {
            var height = new Vector3(0, _cameraSystem.GetCameraOrtographicSize() + 1, 0);

            mushSpawnerParent = GameObject.Find("MushParent").transform;
            enemySpawnerParent = GameObject.Find("EnemyParent").transform;
            mushSpawners = GameObject.Find("MushSpawners").transform.GetComponentsInChildren<Transform>().ToList();
            enemySpawners = GameObject.Find("EnemySpawners").transform.GetComponentsInChildren<Transform>().ToList();

            //mushSpawnerParent.transform.position += height;
            //enemySpawnerParent.transform.position -= height;
        }
        
        void Update()
        {

        }
    }
}