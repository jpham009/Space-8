
using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    static EnemyHealth instance;
    public static EnemyHealth Instance { get { return instance; } }

    public int maxHealth = 100*(int)PlayerPrefs.GetFloat("Difficulty");
    private float currentHealth;

    public GameObject enemyObject;


    void Start()
    {

        //Initialize 
        currentHealth = maxHealth;

    }

    //void Update()
    //{
    //    if (currentHealth <= 0)
    //    {
    //        Die();
    //    }
    //}


    public void Die()
    {
        currentHealth = 0;
        Score.scoreValue += 100;
        //FindObjectOfType<AudioManager>().Play("PlayerDeath");
        Destroy(enemyObject);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //FindObjectOfType<AudioManager>().Play("TakeDamage");

        //If health is less than zero
        if (currentHealth <= 0)
        {
            Die();
        }

    }

    //void OnTriggerEnter2D(Collider2D playerbullet)
    //{
    //    if (playerbullet.gameObject.tag == "PlayerBullet")
    //    {
    //        TakeDamage(15);
    //    }
    //}
}
