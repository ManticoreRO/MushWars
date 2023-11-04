using System;
using UnityEngine;

namespace QDS.MushWars
{
    internal class MoveBehaviour : Behaviour
    {
        private Transform _entityTransform;
        private Func<Vector3> _moveFunction;
        
        public MoveBehaviour(Transform transform, Func<Vector3> moveFunction, Func<bool> checkEnabled)
        {
            _entityTransform = transform;
            _moveFunction = moveFunction;
            _enabledFunc = checkEnabled;
        }

        public override void ApplyBehaviour()
        {
            if (CheckEnabled() == false)
                return;

            _entityTransform.position += _moveFunction();
        }
    }
}
