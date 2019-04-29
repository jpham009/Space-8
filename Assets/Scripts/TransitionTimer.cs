using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionTimer : MonoBehaviour
{
    public GameObject transition; 
    public float duration = 2f;
    private float end = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(duration <= end)
        {
            Destroy(transition);
        }

        duration -= 1 * Time.deltaTime;  
    }
}
