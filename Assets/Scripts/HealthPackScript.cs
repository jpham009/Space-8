using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackScript : MonoBehaviour
{
    public Collider col;
    public GameObject player;
    private PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("touched health");
            player = GameObject.FindGameObjectWithTag("Player");
            playerHealth = player.GetComponent<PlayerHealth>();
            playerHealth.HealPlayer();
            Destroy(this);
        }
    }
    
}
