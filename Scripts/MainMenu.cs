using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace QDS.MushWars
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private Button newGame;
        [SerializeField] private Button continueGame;
        [SerializeField] private Button settings;
        [SerializeField] private Button quit;   
        
        public void OnNewGame()
        {
            if (GameOptions.ShowIntro)
            {
                GameManager.Instance.ChangeState(GameState.Intro);
            }
            else
            {
                GameManager.Instance.ChangeState(GameState.MissionSelect);
            }
        }

        public void OnContinueGame()
        {
            GameManager.Instance.ChangeState(GameState.MissionSelect);
        }

        public void OnSettings()
        {
            GameManager.Instance.ChangeState(GameState.Options);
        }

        public void OnQuitButton()
        {
            Application.Quit();
        }
    }
}