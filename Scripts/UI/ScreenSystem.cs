using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public abstract class Screen : MonoBehaviour
    {
        internal IPlayerStateSystem _playerStateSystem;
        internal IScreenSystem _screenSystem;
        internal ICameraSystem _cameraSystem;
        internal IEntitySystem _entitySystem;

        public virtual void Initialize(IPlayerStateSystem playerStateSystem,
                                       IScreenSystem screenSystem, 
                                       ICameraSystem cameraSystem,
                                       IEntitySystem entitySystem) 
        {
            _playerStateSystem = playerStateSystem;
            _screenSystem = screenSystem;
            _cameraSystem = cameraSystem;
            _entitySystem = entitySystem;   
        }
    }

    public class ScreenSystem : IScreenSystem
    {
        private readonly ScreenConfig _screenConfig;
        private readonly IPlayerStateSystem _playerStateSystem;
        private readonly ICameraSystem _cameraSystem;
        private readonly IEntitySystem _entitySystem;
        
        private Stack<GameObject> _screens = new Stack<GameObject>();

        public ScreenSystem(ScreenConfig screenConfig, 
                            ICameraSystem cameraSystem,
                            IPlayerStateSystem playerStateSystem,
                            IEntitySystem entitySystem)
        {
            _screenConfig = screenConfig;
            _cameraSystem = cameraSystem;
            _playerStateSystem = playerStateSystem;
            _entitySystem = entitySystem;
        }

        // We always close the topmost screen
        public void HideScreen()
        {
            var screen = _screens.Pop();
            if (screen != null) 
            {
                screen.SetActive(false);
                MonoBehaviour.Destroy(screen);
            }

        }

        public void HideAll()
        {
            while (_screens != null)
            {
                HideScreen();
            }
        }

        public void ShowScreen(GameScreens view, bool switchScreens = true)
        {                        
            if (switchScreens) 
            {
                HideScreen();
            }

            var screen = _screenConfig.ScreenPrefabs.Find((o) => o.name == view.ToString());
            
            Screen s;
            switch (view)
            {
                case GameScreens.MainMenu:
                    s = MonoBehaviour.Instantiate<Screen>(screen) as MainMenuScreen;                    
                    break;
                case GameScreens.Options:
                    s = MonoBehaviour.Instantiate<Screen>(screen) as MainMenuScreen;
                    break;
                case GameScreens.Intro:
                    s = MonoBehaviour.Instantiate<Screen>(screen) as IntroScreen;
                    break;
                case GameScreens.SelectMission:
                    s = MonoBehaviour.Instantiate<Screen>(screen) as SelectMissionScreen;
                    break;
                case GameScreens.PlayGame:
                    s = MonoBehaviour.Instantiate<Screen>(screen) as PlayGameScreen;
                    break;
                case GameScreens.EndGame:
                    s = MonoBehaviour.Instantiate<Screen>(screen) as MainMenuScreen;
                    break;
                default:
                    Debug.LogError($"{this} - Invalid screen type!");
                    s = MonoBehaviour.Instantiate<Screen>(screen) as MainMenuScreen;
                    break;
            }

            s.Initialize(_playerStateSystem ,this, _cameraSystem, _entitySystem);
            _screens.Push(s.gameObject);
        }
    }
}