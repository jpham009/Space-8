using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
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
        Debug.Log(col.name);
        if (col.gameObject.tag == "Health Pack") { return; }
        //Enemy enemy = hitInfo.GetComponent<Enemy>();
        //if (enemy != null)
        //{
        //    enemy.TakeDamage(damage);
        //}

        if (col.name == "Player")
        {
            Debug.Log("Hit player!!");// bullet disappears after hitting object
            GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(bulletHit, 0.5f);
            Destroy(bulletObject);
           // Debug.Log("Destroyed bullet");
        }

        // creates animation when bullet hits and destroys instance after some time
        

    }
}
