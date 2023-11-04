using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VContainer.Unity;

namespace QDS.MushWars
{
    internal class EntitiesSystem : IEntitiesSystem, ITickable
    {
        private readonly ICameraSystem _cameraSystem;

        public EntitiesSystem(ICameraSystem cameraSystem) 
        {
            _cameraSystem = cameraSystem;
        }

        public void InitializeEntity()
        {
            throw new NotImplementedException();
        }

        public void DeleteAllEntities()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity()
        {
            throw new NotImplementedException();
        }
       
        public void UpdateEntity()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            //TODO: update all entities here
        }

    }
}
