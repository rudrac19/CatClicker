using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsInputs : MonoBehaviour
{
    public Slider volumeSlider;
    public float volume;
    public AudioSource audio;

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        //volume = volumeSlider.value;
        audio.volume = volumeSlider.value;
    }
}
