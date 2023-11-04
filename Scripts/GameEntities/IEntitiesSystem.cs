namespace QDS.MushWars
{
    internal interface IEntitiesSystem
    {
        public void AddEntity(IEntity entity);
        public void UpdateEntities();
        public void DeleteEntity(IEntity entity);
        public void DeleteAllEntities();

    }
}
