using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWorld4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Boss_Fight");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
