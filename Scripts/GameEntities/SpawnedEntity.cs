using UnityEngine;

namespace QDS.MushWars
{
    public class SpawnedEntity : MonoBehaviour
    {
        internal ICameraSystem _cameraSystem;
        private Sprite _visual;

        private void Start()
        {
            _visual = GetComponent<Sprite>();
        }

        public void Initialize(ICameraSystem cameraSystem)
        {
            _cameraSystem = cameraSystem;
        }  
        
        public void SetVisual(Sprite visual)
        {
            _visual = visual;
        }
    }
}
