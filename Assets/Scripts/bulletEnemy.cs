using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{
    public float speed = 15f;
    public int damage = 3;
    public Rigidbody2D bullet;
    public GameObject bulletObject;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = -transform.right * speed;
    }
    
    void OnTriggerEnter2D (Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            //Dealing damage to the enemy!!
            GameObject player = col.gameObject;
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damage);


            // Debug.Log("Hit player!!");// bullet disappears after hitting object
            GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(bulletHit, 0.5f);
            Destroy(bulletObject);
           // Debug.Log("Destroyed bullet");
        }

        if (col.gameObject.tag == "Tile")
        {
            // creates animation when bullet hits and destroys instance after some time
            GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(bulletHit, 0.2f);

            // bullet disappears after hitting object
            Destroy(bulletObject);
        }


    }
}
