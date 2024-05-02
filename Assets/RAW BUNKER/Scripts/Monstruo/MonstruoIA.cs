using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class MonstruoIA : MonoBehaviour
{
    public NavMeshAgent ai;
    //public Animator anim; para animacion despues
    public Transform PlayerCapsule;
    Vector3 dest;

    void Update()
    {
        dest = PlayerCapsule.position;
        ai.destination = dest;
        if(PickupPieces.piecesCollected == 1 )
        {
            ai.speed = .7f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 2)
        {
            ai.speed = .8f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 3)
        {
            ai.speed = .9f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 4)
        {
            ai.speed = 1f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 5)
        {
            ai.speed = 1.1f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 6)
        {
            ai.speed = 1.2f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 7)
        {
            ai.speed = 1.3f;
            //anim.speed = .2;
        }
        if (PickupPieces.piecesCollected == 8)
        {
            ai.speed = 1.5f;
            //anim.speed = .2;
        }
    }
}
