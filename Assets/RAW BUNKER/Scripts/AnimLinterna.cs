using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimLinterna : MonoBehaviour
{
    public Animator LinternaAnim;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                LinternaAnim.ResetTrigger("Walk");
                LinternaAnim.SetTrigger("Sprint");
            }
            else
            {
                LinternaAnim.ResetTrigger("Sprint");
                LinternaAnim.SetTrigger("Walk");
            }
        }
    }
}
