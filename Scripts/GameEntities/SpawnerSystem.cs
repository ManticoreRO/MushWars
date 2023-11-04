using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{

    internal class SpawnerSystem : ISpawnerSystem
    {
        private readonly SpawnerConfig _config;
        private readonly ICameraSystem _cameraSystem;

        private Dictionary<IEntity, SpawnedEntity> _spawnedEntities = new Dictionary<IEntity, SpawnedEntity>();
        private Dictionary<EntityTypes, List<EntityConfig>> _allEntities = new Dictionary<EntityTypes, List<EntityConfig>>();

        public SpawnerSystem(SpawnerConfig config,
                             ICameraSystem cameraSystem)
        {
            _config = config;
            _cameraSystem = cameraSystem;

            _spawnedEntities = new Dictionary<IEntity, SpawnedEntity>();
            _allEntities = new Dictionary<EntityTypes, List<EntityConfig>>();

            foreach (var entityData in _config.Entities)
            {
                if (_allEntities.ContainsKey(entityData.EntityType) == false)
                {
                    _allEntities.Add(entityData.EntityType, new List<EntityConfig>());                    
                }
                _allEntities[entityData.EntityType].Add(entityData);
            }
        }

        public void SpawnEntity(IEntity entity)
        {
            var position = Vector3.zero;
            Sprite sprite = null;

            if (entity is EntitySpawnData)
            {
                var visualEntityData = entity as EntitySpawnData;
                position = visualEntityData.GetStartingPosition();
                sprite = _allEntities[visualEntityData.GetEntityType()].Find((o) => o.name == visualEntityData.GetSpriteType().ToString()).Appearance;
            }
            
            var prefab = GetPrefab(entity.GetEntityType());
            var spawned = MonoBehaviour.Instantiate(prefab, position, Quaternion.identity);
            if (_spawnedEntities.ContainsKey(entity))
            {
                Debug.LogError($"{this} - Trying to link one entity with more than one gameobject");
                return;
            }
            var spawnedEntity = spawned.GetComponent<SpawnedEntity>();
            spawnedEntity.SetVisual(sprite);
            _spawnedEntities.Add(entity, spawnedEntity);           
        }

        public void DestroyEntity(IEntity entity)
        {
            var go = _spawnedEntities[entity];
            if (go != null)
            {
                MonoBehaviour.Destroy(go);
                _spawnedEntities.Remove(entity);                
            }
            else
            {
                Debug.LogError($"{this} - Trying to destroy non-existant entity!");
            }
        }

        private GameObject GetPrefab(EntityTypes entityType) 
        {
            return _config.Prefabs.Find((o)=>o.name == entityType.ToString());  
        }
    }
}
