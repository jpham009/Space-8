using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCellScript : MonoBehaviour
{
    public GameObject fuelcell;
    private Collider2D playerCol;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void OnTriggerEnter2D(Collider2D playerCol)
    {
        if (playerCol.gameObject.tag == "Player")
        {
            if (fuelcell.gameObject.tag == "Fuel Cell")
            {
                Debug.Log("touched fuel cell");
                player = GameObject.FindGameObjectWithTag("Player");
                FindObjectOfType<AudioManager>().Play("Heal");
                Destroy(fuelcell);
                Score.scoreValue += 1000;
            }
            else
            {
                Debug.Log("unknown item");
            }
        }
    }
    
}
