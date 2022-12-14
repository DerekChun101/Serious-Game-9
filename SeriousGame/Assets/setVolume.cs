using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVolume : MonoBehaviour
{
    public AudioMixer mixer;
    
    public void setLevel(float sliderVal)
    {
            mixer.SetFloat("musicVol", Mathf.Log10(sliderVal) * 20);
    }
}
