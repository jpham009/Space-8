using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JEnemyWeapon : MonoBehaviour {

	//[SerializeField]
	public GameObject enemybullet;

    public Transform firepoint;
    private GameObject player;

    float fireRate;
	float nextFire;
    //public float timeBtwShots;
    //public float startTimeBtwShots;

    // Use this for initialization
    void Start () {
		fireRate = 1f;
		nextFire = Time.time;
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
        if (Mathf.Abs(Vector2.Distance(transform.position, player.transform.position)) < 15)
        {
            if (Time.time > nextFire)
            {
                GameObject bullet = (GameObject)Instantiate(enemybullet, firepoint.position, firepoint.rotation);
                Destroy(bullet, 1.0f);
                nextFire = Time.time + fireRate;
            }
		}
    
    }

}
