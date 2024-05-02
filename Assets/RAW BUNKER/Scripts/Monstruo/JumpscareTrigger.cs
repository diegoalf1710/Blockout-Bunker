using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpscareTrigger : MonoBehaviour
{
    public GameObject playerObj, jumpscareCam, SonidosColeccion;
    //public Animator anim; 
    public string sceneName;
    public float jumpscareTime;
    public MonstruoIA scriptMonstruo;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerObj.SetActive(false);
            scriptMonstruo.enabled = false;
            //monsterAnim,speed = 1f;
            jumpscareCam.SetActive(true);
            SonidosColeccion.SetActive(false);
            StartCoroutine(changeScene());
            //monsterAnim.SetTrigger("Jumpscare");
        }
    }
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
