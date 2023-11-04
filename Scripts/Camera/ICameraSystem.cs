using UnityEngine;

namespace QDS.MushWars
{
    public interface ICameraSystem
    {
        public void SwitchOrthographic(bool value);
        public Rect GetCameraBounds();
        public float GetCameraOrtographicSize();
    }
}
