namespace QDS.MushWars
{
    public interface IEntitySystem
    {
        public void AddEntity(IEntity entity);
        public void UpdateEntities();
        public void DeleteEntity(IEntity entity);
        public void DeleteAllEntities();

    }
}
