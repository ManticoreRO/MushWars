using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDS.MushWars
{
    internal abstract class Behaviour : IBehaviour
    {
        private bool _enabled;
        internal Func<bool> _enabledFunc;

        public Behaviour() { }  
        public void SetEnabled(bool enabled) { _enabled = enabled; }
        
        public bool CheckEnabled()
        {
            _enabled = _enabledFunc();
            return _enabled;
        }

        public virtual void ApplyBehaviour() { }
    }
}
