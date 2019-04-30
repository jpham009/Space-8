﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
        //Debug.Log(volume);
    }
}