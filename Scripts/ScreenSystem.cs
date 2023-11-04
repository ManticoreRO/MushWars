using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public abstract class Screen : MonoBehaviour
    {
        internal IScreenSystem _screenSystem;
        internal ICameraSystem _cameraSystem;

        public virtual void Initialize(IScreenSystem screenSystem, 
                                       ICameraSystem cameraSystem) 
        {
            _screenSystem = screenSystem;
            _cameraSystem = cameraSystem;
        }
    }

    public class ScreenSystem : IScreenSystem
    {
        private readonly ScreenConfig _screenConfig;
        private readonly ICameraSystem _cameraSystem;
        
        private Stack<GameObject> _screens = new Stack<GameObject>();

        public ScreenSystem(ScreenConfig screenConfig, 
                            ICameraSystem cameraSystem)
        {
            _screenConfig = screenConfig;
            _cameraSystem = cameraSystem;
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

            s.Initialize(this, _cameraSystem);
            _screens.Push(s.gameObject);
        }
    }
}