using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullPuerta : MonoBehaviour
{
    [SerializeField]Transform playerCam;
    [SerializeField] Transform distCheck;
    [SerializeField] Transform soporte;

    [SerializeField] float movSpeed;
    [SerializeField] Vector2 rotationConstraints;

    bool movingDoor;
    float rotation;
    Vector3 targetPos;
    void Start()
    {
        targetPos = distCheck.position;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(Physics.Raycast(playerCam.position, playerCam.forward, out RaycastHit Hit, 1.5f))
            {
                if (Hit.collider.CompareTag("Puerta"))
                {
                    movingDoor = true;
                }
            }
        }

        if(movingDoor)
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                movingDoor = false;
            }
            targetPos = playerCam.position + playerCam.forward * 2f;
        }

        rotation += Mathf.Clamp(GetRotation() * 5000 * Time.deltaTime, -movSpeed, movSpeed);
        rotation = Mathf.Clamp(rotation, rotationConstraints.x, rotationConstraints.y);
        soporte.localRotation = Quaternion.Euler(0, rotation, 0);
    }

    float GetRotation()
    {
        float firstDistance = (distCheck.position - targetPos).sqrMagnitude;
        soporte.Rotate(Vector3.up);
        float secondDistance = (distCheck.position - targetPos).sqrMagnitude;
        soporte.Rotate(Vector3.up);
        return secondDistance - firstDistance;
    }
}
