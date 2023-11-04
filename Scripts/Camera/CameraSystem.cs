using System.Collections;
using UnityEngine;

namespace QDS.MushWars
{
    public class CameraSystem : ICameraSystem
    {
        private Camera _mainCamera;
        private Camera _uiCamera;

        public CameraSystem(Camera mainCamera, Camera uiCamera)
        {
            _mainCamera = mainCamera;     
            _uiCamera = uiCamera;
        }

        public Rect GetCameraBounds()
        {
            if (_mainCamera.orthographic == false)
            {
                Debug.LogWarning($"{this} - Camera is not orthographic. Will return bounds set to 0!");
                return Rect.zero;
            }
            var dist = _mainCamera.orthographicSize;
            return new Rect(0,-dist,dist,dist);
        }

        public void SwitchOrthographic(bool value)
        {
            _mainCamera.orthographic = value;
        }

        public float GetCameraOrtographicSize()
        {
            return _mainCamera.orthographicSize;
        }
    }
}