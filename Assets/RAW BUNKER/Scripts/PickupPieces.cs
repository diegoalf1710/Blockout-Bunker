using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupPieces : MonoBehaviour
{
    public GameObject collectTextObj, intText;
    public AudioSource pickupSound, ambianceLayer1, ambianceLayer2, ambianceLayer3, ambianceLayer4, ambianceLayer5, ambianceLayer6, ambianceLayer7, ambianceLayer8;
    public bool interactable;
    public static int piecesCollected;
    public Text collectText;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                piecesCollected = piecesCollected + 1;
                collectText.text = piecesCollected + "/8 shotgun pieces";
                collectTextObj.SetActive(true);
                pickupSound.Play();
                if (piecesCollected == 1)
                {
                    ambianceLayer1.Play();
                }
                if (piecesCollected == 2)
                {
                    ambianceLayer2.Play();
                }
                if (piecesCollected == 3)
                {
                    ambianceLayer3.Play();
                }
                if (piecesCollected == 4)
                {
                    ambianceLayer4.Play();
                }
                if (piecesCollected == 5)
                {
                    ambianceLayer5.Play();
                }
                if (piecesCollected == 6)
                {
                    ambianceLayer6.Play();
                }
                if (piecesCollected == 7)
                {
                    ambianceLayer7.Play();
                }
                if (piecesCollected == 8)
                {
                    ambianceLayer8.Play();
                }
                intText.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }
        }
    }
}