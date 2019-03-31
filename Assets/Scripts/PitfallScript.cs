using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitfallScript : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("entered " + col.name);
        Destroy(player);
           
    }
}
