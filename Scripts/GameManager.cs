using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public enum GameState
    {
        MainMenu,
        Intro,
        MissionSelect,
        Game,
        PrepareWave,
        EndGame
    }

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

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

        private void ExecuteState(GameState state)
        {
            switch (state)
            {
                case GameState.MainMenu:
                    break;
                case GameState.Intro:
                    break;
                case GameState.MissionSelect:
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