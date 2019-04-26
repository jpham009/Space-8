using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemy : MonoBehaviour
{
    public Transform firepoint;
    public GameObject Projectile;

    public float speed;
    public GameObject player;
    private Transform playerTransform;
    private Vector2 target;

    void Start()
    {
        playerTransform = player.transform;

        target = new Vector2(playerTransform.position.x, playerTransform.position.y);
        Shoot();
    }
    // Update is called once per frame
    void Update()
    {
        //enemy script
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {

            DestroyProjectile();
        }


    }

    public void Shoot()
    {
        // creates a shooting bullet and destroys after some time
        GameObject bullet = (GameObject)Instantiate(Projectile, firepoint.position, firepoint.rotation);
        Score.scoreValue -= 1;
        FindObjectOfType<AudioManager>().Play("Zap");
        Destroy(bullet, 1.0f);
    }
    void DestroyProjectile()
    {
        Destroy(this);
    }

}
