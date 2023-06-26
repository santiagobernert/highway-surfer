using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider volumeSlider;

    public void MusicVolume(){
        AudioListener.volume = volumeSlider.value;
    }
}