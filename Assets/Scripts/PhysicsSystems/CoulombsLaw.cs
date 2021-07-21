
using System;
using PhysicsSystems;
using UnityEngine;

public class CoulombsLaw : MonoBehaviour
{
    //Coulomb's Law - Scalar Form:
    //Fe = Abs(Q1*Q2)/distance^2

    [SerializeField] private float chargeA;
    [SerializeField] private MyRigidBody bodyA;
    [SerializeField] private float chargeB;
    [SerializeField] private MyRigidBody bodyB;


    
    private const double _coulombConst = 9e+9D;
    
    
    private void FixedUpdate()
    {
        var posA = bodyA.Transform.position;
        var posB = bodyB.Transform.position;
        var distVector = posA - posB; ;
        var sqrDist = Vector3.SqrMagnitude(distVector);
        var dir = distVector.normalized * (chargeA*chargeB);

        var resultantForce = _coulombConst * (Mathf.Abs(chargeA * chargeB)) / sqrDist;
        
        bodyA.MoveTowards(resultantForce, dir);
        bodyB.MoveTowards(resultantForce, -dir);
    }
}
