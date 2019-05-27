using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JEnemyMovement : MonoBehaviour
{
		public float speed;
		public float stoppingDistance;
		public float retreatDistance;
		//public float timeBtwShots;
		//public float startTimeBtwShots;
		//public GameObject projectile;
		public Transform player;
        public Rigidbody2D enemy;
        public float DifficultyFactor;
        //public Vector2 attackRadius = new Vector2 (10,10);


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    	//timeBtwShots = startTimeBtwShots;
        enemy = GetComponent<Rigidbody2D>();

        //Increase speed if difficulty increases
        //DifficultyFactor = PlayerPrefs.GetFloat("Difficulty");
        DifficultyFactor = 1;
    }

    // Update is called once per frame
    void Update()
    {

        //flip enemy direction based on whether the player is on left or right
        if (player.position.x < transform.position.x){
            //transform.localScale = new Vector3(1,1,1);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(player.position.x > transform.position.x){
            //transform.localScale = new Vector3(-1,1,1);
            transform.eulerAngles = new Vector3(0, 180, 0);

        }

        //move enemy towards player
        if(Mathf.Abs(Vector2.Distance(transform.position, player.position)) < 15){
            if (Vector2.Distance(transform.position, player.position) > 15)
            { 
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime * DifficultyFactor);
            }
            else
            {
        	        transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime*DifficultyFactor);
            }
        }





        

        //if(timeBtwShots <= 0){
        //	Instantiate(projectile, transform.position, Quaternion.identity);
        //	timeBtwShots = startTimeBtwShots;
        //} else {
        //	timeBtwShots = Time.deltaTime;
        //}



    }
    void OnTriggerEnter2D(Collider2D col)
    {if (col.tag == "Tile"){
        enemy.AddForce(Vector2.up*200f);
    }
    }
}