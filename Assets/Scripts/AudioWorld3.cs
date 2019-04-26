using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWorld3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Rainbow_World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
