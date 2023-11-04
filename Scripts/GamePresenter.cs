using VContainer.Unity;

namespace QDS.MushWars
{
    public class GamePresenter : IStartable
    {
        private readonly IScreenSystem _screenSystem;
        private readonly ICameraSystem _cameraSystem;

        public GamePresenter(IScreenSystem screenSystem,
                             ICameraSystem cameraSystem)
        {
            _screenSystem = screenSystem;
            _cameraSystem = cameraSystem;
        }
        
        public void Start()
        {
            _screenSystem.ShowScreen(GameScreens.MainMenu, false);
        }
    }
}