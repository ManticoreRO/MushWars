using UnityEngine;

namespace QDS.MushWars
{
    public enum EntityTypes
    {
        None,
        Mushroom,
        Enemy,
        Projectile,
        PowerUp
    }

    public interface ISpawnerSystem
    {
        public void SpawnEntity(IEntity entity);
        public void DestroyEntity(IEntity entity);
    }
}
