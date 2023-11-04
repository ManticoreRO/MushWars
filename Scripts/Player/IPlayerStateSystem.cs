
namespace QDS.MushWars
{
    public interface IPlayerStateSystem
    {
        public PlayerState GetPlayerState();
        public void Save();
        public void Load(); 
    }
}
