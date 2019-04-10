using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 15;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);

        /*Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }*/

        // creates animation when bullet hits and destroys instance after some time
        GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(bulletHit, 0.5f);

        // bullet disappears after hitting object
        Destroy(gameObject);
    }
}
