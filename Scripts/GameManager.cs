using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public enum GameState
    {
        MainMenu,
        Options,
        Intro,
        MissionSelect,
        Game,
        PrepareWave,
        EndGame
    }

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        [SerializeField] private Camera mainCamera;
        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject introScene;

        [SerializeField] private Material introSkyBox;

        [SerializeField] private MissionManager missionManager;
        private GameState _gameState;
        private void Awake()
        {
            if (Instance==null)
            {
                Instance = this;
                DontDestroyOnLoad(Instance);
            }
            else
            {
                Destroy(this);
            }
        }

        private void Start()
        {
            _gameState = GameState.MainMenu;

            ExecuteState(_gameState);
        }

        public void ChangeState(GameState newState)
        {
            _gameState = newState;
            ExecuteState(_gameState);
        }

        private void ExecuteState(GameState state)
        {
            switch (state)
            {
                case GameState.MainMenu:
                    mainCamera.orthographic = true;                    
                    mainMenu.SetActive(true);
                    break;
                case GameState.Intro:
                    mainMenu.SetActive(false);
                    mainCamera.orthographic = false;
                    introScene.SetActive(true);
                    break;
                case GameState.MissionSelect:
                    mainMenu.SetActive(false);
                    introScene.SetActive(false);
                    missionManager.Activate(true);
                    break;
                case GameState.Game:
                    break;
                case GameState.PrepareWave:
                    break;
                case GameState.EndGame:
                    break;
            }
        }        
    }
}