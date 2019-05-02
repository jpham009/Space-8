using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 15;
    public GameObject bulletObj;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        bulletObj.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }
    
    void OnTriggerEnter2D (Collider2D col)
    {
        Debug.Log(col.name);
        //if (col.gameObject.tag == "Health Pack") { return; }
        if (col.gameObject.tag == "Enemy")
        {
            //Dealing damage to the enemy!!
            GameObject enemy = col.gameObject;
            EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(damage);

            // creates animation when bullet hits and destroys instance after some time
            GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(bulletHit, 0.2f);
            
            // bullet disappears after hitting object
            Destroy(bulletObj);
        }
        if(col.gameObject.tag == "Tile")
        {
            // creates animation when bullet hits and destroys instance after some time
            GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(bulletHit, 0.2f);

            // bullet disappears after hitting object
            Destroy(bulletObj);
        }
    }
}
