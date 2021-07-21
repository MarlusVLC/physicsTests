using System;
using UnityEngine;

namespace Auxiliar
{
    public class MonoCache : MonoBehaviour
    {
        private Transform _transform;

        protected virtual void  Awake()
        {
            CacheTransform();
        }

        private void CacheTransform()
        {
            if (!_transform)
                _transform = transform;
        }

        public Transform Transform => _transform;
    }
}