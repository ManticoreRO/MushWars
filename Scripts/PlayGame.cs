using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public class PlayGame : MonoBehaviour
    {
        [SerializeField] private Transform mushSpawnerParent;
        [SerializeField] private Transform enemySpawnerParent;
        [SerializeField] private Transform mushParent;
        [SerializeField] private Transform enemyParent;
        [SerializeField] private List<Transform> mushSpawners;
        [SerializeField] private List<Transform> enemySpawners;
        [SerializeField] private GameObject MushPrefab;
        [SerializeField] private GameObject EnemyPrefab;

        public void SpawnMush1()
        {
            var spawner = mushSpawners[Random.Range(0, mushSpawners.Count - 1)];
            var obj = GameManager.Instance.GetEntities().Mushrooms[0];
            var mush = Instantiate(MushPrefab, spawner.position, Quaternion.identity);
            mush.transform.SetParent(mushParent);
            mush.GetComponent<MushroomController>().Setup(obj);
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