using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
		public float speed;
		public float stoppingDistance;
		public float retreatDistance;
		public float timeBtwShots;
		public float startTimeBtwShots;
		public GameObject projectile;
		public Transform player;
        public Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
            player = GameObject.FindGameObjectWithTag("Player").transform;
    		timeBtwShots = startTimeBtwShots;
            rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        //flip enemy direction based on whether the player is on left or right
        if(player.position.x < transform.position.x){
            transform.localScale = new Vector3(1,1,1);
        }else if(player.position.x > transform.position.x){
            transform.localScale = new Vector3(-1,1,1);
        }

        //move enemy towards player
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance) {
        	transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance){
        	transform.position = this.transform.position;
        } else if (Vector2.Distance(transform.position, player.position) < retreatDistance){
        	transform.position = Vector2.MoveTowards(transform.position, player.position, -speed*Time.deltaTime);
        }

        if(timeBtwShots <= 0){
        	Instantiate(projectile, transform.position, Quaternion.identity);
        	timeBtwShots = startTimeBtwShots;
        } else {
        	timeBtwShots = Time.deltaTime;
        }
    }
            void OnTriggerEnter2D(Collider2D col)
        {if (col.tag == "Tile"){
            rb.AddForce(Vector2.up*200f);
        }
        }
}