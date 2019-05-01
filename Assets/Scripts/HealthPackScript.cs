using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackScript : MonoBehaviour
{
    public GameObject healthItem;
    private Collider playerCollider;
    public GameObject player;
    private PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void OnTriggerEnter2D(Collider2D playerCollider)
    {
        if (playerCollider.gameObject.tag == "Player")
        {
            if (healthItem.gameObject.tag == "Health Pack")
            {
                Debug.Log("touched health");
                player = GameObject.FindGameObjectWithTag("Player");
                playerHealth = player.GetComponent<PlayerHealth>();
                playerHealth.HealPlayer();
                FindObjectOfType<AudioManager>().Play("Heal");
                Destroy(healthItem);
                Score.scoreValue += 5;
            }
            else if(healthItem.gameObject.tag == "Oxygen Bubble")
            {
                Debug.Log("oxy bubble");
                player = GameObject.FindGameObjectWithTag("Player");
                playerHealth = player.GetComponent<PlayerHealth>();
                playerHealth.Breathe();
                FindObjectOfType<AudioManager>().Play("Bubbles");
                Destroy(healthItem);
                Score.scoreValue += 10;
            }
            else
            {
                Debug.Log("unknown item");
            }
        }
    }
    
}
