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
    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        if (hitInfo.gameObject.tag == "Health Pack") { return; }
        if (hitInfo.gameObject.tag == "Enemy")
        {
            // creates animation when bullet hits and destroys instance after some time
            GameObject bulletHit = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(bulletHit, 0.5f);

            // bullet disappears after hitting object
            Destroy(bulletObj);
        }

        
    }
}
