using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
	public float speed;
    public GameObject player; 
    private Transform playerTransform;
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.transform;

    	target = new Vector2(playerTransform.position.x, playerTransform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    	if(transform.position.x == target.x && transform.position.y == target.y){
            
    		DestroyProjectile();
    	}
    }
    void OnTriggerEnter2d(Collider2D other){
    	if(other.tag == "Player"){

            //player.PlayerHealth.TakeDamage(); 

    	}
        DestroyProjectile();
    }
    void DestroyProjectile(){
    	Destroy(this);
    }
}
