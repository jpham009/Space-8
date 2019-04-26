using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWorld2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Acid_Rain");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
