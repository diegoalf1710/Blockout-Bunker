using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumenSlider : MonoBehaviour
{
    public AudioMixer mixerMast;

    public void SetLevel (float sliderValue)
    {
        mixerMast.SetFloat("VolumenMaestro", Mathf.Log10(sliderValue * 20));
    }
}
