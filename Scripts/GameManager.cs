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
        EndGame
    }

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public GameState DebugStart;

        [SerializeField] private Camera mainCamera;
        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject introScene;
        [SerializeField] private SelectMission missionScreen;
        [SerializeField] private GameObject playGame;

        [SerializeField] private List<MissionConfig> missionData;
        [SerializeField] private EntitiesData entitiesData;

        [SerializeField] private Material introSkyBox;
       
        private GameState _gameState;
        private GameObject _activeScreen;

        private PlayerState _playerState;

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
            _gameState = DebugStart;
            _activeScreen = mainMenu;

            ExecuteState(_gameState);
        }

        public void ChangeState(GameState newState)
        {
            _activeScreen?.SetActive(false);
            _gameState = newState;
            ExecuteState(_gameState);
        }

        public void SwitchCamera(bool ortho)
        {
            mainCamera.orthographic = ortho;
        }

        private void ExecuteState(GameState state)
        {
            switch (state)
            {
                case GameState.MainMenu:
                    _activeScreen = mainMenu;
                    break;
                case GameState.Intro:
                    _activeScreen = introScene;                    
                    break;
                case GameState.MissionSelect:                    
                    InitializeMissionScreen();
                    _activeScreen = missionScreen.gameObject;                    
                    break;                
                case GameState.Game:
                    _activeScreen = playGame;
                    break;                
                case GameState.EndGame:                    
                    break;
            }

            _activeScreen?.SetActive(true);
        }

        public EntitiesData GetEntities() => entitiesData;

        private void InitializeMissionScreen()
        {
            missionScreen.SetMissionData(_playerState.CurrentMission, 
                                         missionData[_playerState.CurrentMission].MissionName, 
                                         missionData[_playerState.CurrentMission].MissionDescription);
            missionScreen.SetWaveData(missionData[_playerState.CurrentMission].WavesAvailable, _playerState.CurrentSpores);
            missionScreen.SetMushData(_playerState.UnlockedMushes);
        }
    }
}