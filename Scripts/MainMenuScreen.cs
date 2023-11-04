using UnityEngine;
using TMPro;
using UnityEngine.UI;
using VContainer;

namespace QDS.MushWars
{
    public class MainMenuScreen : Screen
    {        
        [SerializeField] private Button newGame;
        [SerializeField] private Button continueGame;
        [SerializeField] private Button settings;
        [SerializeField] private Button quit;

        public void OnNewGame()
        {
            var screenToShow = (GameOptions.ShowIntro) ? GameScreens.Intro : GameScreens.SelectMission;
            
            _screenSystem.ShowScreen(screenToShow);            
        }

        public void OnContinueGame()
        {
            _screenSystem.ShowScreen(GameScreens.SelectMission);
        }

        public void OnSettings()
        {
            _screenSystem.ShowScreen(GameScreens.Options);
        }

        public void OnQuitButton()
        {
            Application.Quit();
        }
    }
}