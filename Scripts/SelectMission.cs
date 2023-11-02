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

        [SerializeField] private List<Sprite> planetImages;        
                       
        public void SetMissionData(int spriteId, string missionNameText, string missionDescText)
        {
            planet.sprite = planetImages[spriteId];
            missionName.text = missionNameText;
            missionDesc.text = missionDescText;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}