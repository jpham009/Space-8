using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    public void Shoot()
    {
        // creates a shooting bullet and destroys after some time
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        //Score.scoreValue -= 1;
        FindObjectOfType<AudioManager>().Play("Zap");
        Destroy(bullet, 1.0f);
    }
}
