using System;

namespace QDS.MushWars
{
    public interface IBehaviour
    {
        public void SetEnabled(bool enabled);
        public void ApplyBehaviour();
    }
}
