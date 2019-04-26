using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JEnemyWeapon : MonoBehaviour {

	//[SerializeField]
	public GameObject enemybullet;

    public Transform firepoint;

    float fireRate;
	float nextFire;
    //public float timeBtwShots;
    //public float startTimeBtwShots;

    // Use this for initialization
    void Start () {
		fireRate = 1f;
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
            GameObject bullet = (GameObject)Instantiate(enemybullet, firepoint.position, firepoint.rotation);
            Destroy(bullet, 1.0f);
            nextFire = Time.time + fireRate;
		}
    
    }

}
