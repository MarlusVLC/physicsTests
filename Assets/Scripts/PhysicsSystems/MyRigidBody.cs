using Auxiliar;
using UnityEngine;

namespace PhysicsSystems
{
    [RequireComponent(typeof(Rigidbody))]
    public class MyRigidBody : MonoCache
    {
        private Rigidbody _rb;

        protected override void Awake()
        {
            base.Awake();
            _rb = GetComponent<Rigidbody>();
        }

        public void MoveTowards(double force, Vector3 direction)
        {
            _rb.AddForce((float)force*direction);
        }
    }
}