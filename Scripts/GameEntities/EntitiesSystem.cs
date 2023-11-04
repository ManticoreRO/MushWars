using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VContainer.Unity;

namespace QDS.MushWars
{
    internal class EntitiesSystem : IEntitiesSystem, ITickable
    {
        private readonly ICameraSystem _cameraSystem;

        private List<IEntity> _entities = new List<IEntity>();

        public EntitiesSystem(ICameraSystem cameraSystem) 
        {
            _cameraSystem = cameraSystem;
        }

        public void AddEntity(IEntity entity)
        {
            _entities.Add(entity);
        }

        public void DeleteAllEntities()
        {
            foreach (var entity in _entities)
            {
                DeleteEntity(entity);
            }
        }

        public void DeleteEntity(IEntity entity)
        {
            if (entity == null) return;
            if (_entities.Contains(entity))
            {
                entity.OnDestroy();
                _entities.Remove(entity);
            }
            else
            {
                Debug.LogWarning($"{this} - Trying to remove non-existant entity!");
            }
        }
       
        public void UpdateEntities()
        {
            if (_entities.Count == 0) return;

            foreach (var entity in _entities)
            {
                entity.Update();
            }
        }

        public void Tick()
        {
            UpdateEntities();
        }

    }
}
