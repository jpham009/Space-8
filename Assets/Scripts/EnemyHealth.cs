
using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    static EnemyHealth instance;
    public static EnemyHealth Instance { get { return instance; } }
    //public int maxHealth = 50*(int)PlayerPrefs.GetFloat("Difficulty");
    public int maxHealth = 100;
    private float currentHealth;
    public GameObject enemyObject;


    void Start()
    {
        //Initialize 
        currentHealth = maxHealth;
    }

    public void Die()
    {
        currentHealth = 0;
        Score.scoreValue += 1250;
        if (enemyObject.tag == "Boss")
        {
            Score.scoreValue += 8750;
        }
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
}
