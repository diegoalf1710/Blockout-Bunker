using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public float RotationSpeed = 1.0f;

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * RotationSpeed;

        transform.Rotate(Vector3.right, XaxisRotation);
    }
}
