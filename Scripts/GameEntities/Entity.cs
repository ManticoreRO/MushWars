using System;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;

namespace QDS.MushWars
{
    public abstract class Entity : IEntity
    {
        private List<IBehaviour> _behaviours;
        
        public virtual EntityTypes GetEntityType() { return default; }

        public void AddBehaviour(IBehaviour behaviour)
        {
            if (_behaviours == null)
                _behaviours = new List<IBehaviour>();   
            _behaviours.Add(behaviour);
        }

        public void RemoveBehaviour(IBehaviour behaviour)
        {
            if (behaviour == null) return;
            if (_behaviours.Contains(behaviour))
            {
                _behaviours.Remove(behaviour);                
            }
            else
            {
                Debug.LogWarning($"{this} - Trying to remove non-existant behaviour!");
            }
        }

        public List<IBehaviour> FindBehaviours(Type type)
        {
            if (_behaviours == null) return null;
            return _behaviours.FindAll((o) => o.GetType() == type);
        }

        public IBehaviour GetBehaviour(int id)
        {
            if (_behaviours==null || id > _behaviours.Count || id < 0) return null;
            return _behaviours[id];
        }

        public virtual void OnDestroy()
        {            
        }

        public virtual void OnInstantiate()
        {            
        }

        public void Update()
        {
            if (_behaviours == null || _behaviours.Count == 0) return;

            foreach (var behaviour in _behaviours)
            {
                behaviour.ApplyBehaviour();
            }
        }
    }
}
