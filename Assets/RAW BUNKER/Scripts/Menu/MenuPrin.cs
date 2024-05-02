using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrin : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("GameRAW");
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
