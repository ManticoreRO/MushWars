using System;
using System.Collections.Generic;

namespace QDS.MushWars
{
    internal interface IEntity
    {
        public void AddBehaviour(IBehaviour behaviour);
        public void RemoveBehaviour(IBehaviour behaviour);
        public IBehaviour GetBehaviour(int id);
        public List<IBehaviour> FindBehaviours(Type type);
        public void OnInstantiate();        
        public void OnDestroy();
    }
}
