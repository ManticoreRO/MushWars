using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QDS.MushWars
{
    public class MissionManager : MonoBehaviour
    {
        [SerializeField] private SelectMission missionScreen;
        [SerializeField] private List<MissionConfig> missionData;

        private int _currentMission;

        private void Start()
        {
            _currentMission = 0;
            InitializeMissionScreen();
        }

        private void InitializeMissionScreen()
        {
            missionScreen.SetMissionData(_currentMission, missionData[_currentMission].MissionName, missionData[_currentMission].MissionDescription);
        }

        public void Activate(bool active)
        {
            InitializeMissionScreen();
            missionScreen.gameObject.SetActive(true);
        }
    }
}