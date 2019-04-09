using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitfallScript : MonoBehaviour
{

    public GameObject player;
    private PlayerHealth playerHealth;
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
        if (col.name == "DeathPit")
        {
            Debug.Log("entered " + col.name);
            playerHealth = player.GetComponent<PlayerHealth>();
            playerHealth.currentHealth = 0;
            playerHealth.currentOxygen = 0;
            //player.currentHealth = 0; 
            //Destroy(player);
        }
           
    }
}
