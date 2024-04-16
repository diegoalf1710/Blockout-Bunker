using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float playerReach = 3f;
    interact currentinteract;
    
    // Update is called once per frame
    void Update()
    {
        Checkinteract();
        if(Input.GetKeyDown(KeyCode.F) && currentinteract != null)
        {
            currentinteract.Interact();
        }
    }

    void Checkinteract()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if(Physics.Raycast(ray, out hit, playerReach))
        {
            if(hit.collider.tag == "interactuable")
            {
                interact newInteract = hit.collider.GetComponent<interact>();

                if(currentinteract && newInteract != currentinteract)
                {
                    currentinteract.DisableOutline();
                }
                if(newInteract.enabled)
                {
                    SetNewCurrentinteract(newInteract);
                }
                else
                {
                    DisableCurrentinteract();
                }
            }
            else
            {
                DisableCurrentinteract();
            }
        }
    }

    void SetNewCurrentinteract(interact newInteract)
    {
        currentinteract = newInteract;
        currentinteract.EnableOutline();
    }

    void DisableCurrentinteract()
    {
        if (currentinteract)
        {
            currentinteract.DisableOutline();
            currentinteract = null;
        }
    }
}
