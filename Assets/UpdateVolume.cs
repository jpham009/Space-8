using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVolume : MonoBehaviour
{
    public AudioSource myMusic;

    // Start is called before the first frame update
    void Start()
    {
        myMusic.volume = PlayerPrefs.GetFloat("Volume",(float).5);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
