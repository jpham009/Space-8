﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWorld1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("IceWorld");
        AudioListener.volume = PlayerPrefs.GetFloat("Volume", (float).5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
