using UnityEngine;

namespace QDS.MushWars
{
    public enum SpriteTypes
    {
        Sprout,
        Dasher,
        Defender,
        Scout,
        Probe
    }

    public class EntitySpawnData : Entity
    {        
        private SpriteTypes _type;
        private Vector3 _startingPosition;

        public EntitySpawnData() { }
        public EntitySpawnData(SpriteTypes type, Vector3 startingPosition)
        {            
            _type = type;
            _startingPosition = startingPosition;
        }

        public override EntityTypes GetEntityType()
        {
            return EntityTypes.Mushroom;
        }

        public SpriteTypes GetSpriteType()
        { 
            return _type; 
        }

        public Vector3 GetStartingPosition()
        {
            return _startingPosition;
        }
    }
}
