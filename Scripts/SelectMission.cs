using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace QDS.MushWars
{
    public class SelectMission : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer planet;
        [SerializeField] private TMP_Text missionName;
        [SerializeField] private TMP_Text missionDesc;
        [SerializeField] private TMP_Text availableSpores;
        [SerializeField] private List<Sprite> planetImages;
        [SerializeField] private List<Image> availableMushes;
        
        public void SetMissionData(int spriteId, string missionNameText, string missionDescText)
        {
            planet.sprite = planetImages[spriteId];
            missionName.text = missionNameText;
            missionDesc.text = missionDescText;
        }
       
        public void SetWaveData(int availableWavesData, int availableSporesData)
        {            
            availableSpores.text = $"$pores: {availableSpores}";
        }

        public void SetMushData(List<int> unlockedMushes)
        {
            for (int i = 0; i < availableMushes.Count; i++)
            {
                availableMushes[i].gameObject.SetActive(unlockedMushes.Contains(i));
            }
        }

        public void OnStartButton()
        {
            GameManager.Instance.ChangeState(GameState.Game);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}