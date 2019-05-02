﻿
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    static PlayerHealth instance;
    public static PlayerHealth Instance { get { return instance; } }
    bool canTakeDamage = true;
    public int maxHealth = 100;
    public int maxOxygen = 100; 
    public float currentHealth;
    public float currentOxygen;
    public float invulnerabilityTime = 0.5f;
    public Camera cam;
    public GameObject player;
    public SimpleHealthBar healthBar;
    public SimpleHealthBar oxygenBar;
    public Animator bloodAnim;

    void Start()
    {
        //Initialize Player 
        currentHealth = maxHealth;
        currentOxygen = maxOxygen;

        // Update Health Bar with the updated values of Health and Oxygen
        healthBar.UpdateBar(currentHealth, maxHealth);
        oxygenBar.UpdateBar(currentOxygen, maxOxygen);
    }

    void Update()
    {
        // Oxygen drop rate
        currentOxygen -= (float) 0.05;

        if (currentHealth < 20f || currentOxygen < 20f)
        {
            bloodAnim.SetBool("sampleBool", true);
        }
        else {
            bloodAnim.SetBool("sampleBool",false);
        }

        if(currentOxygen <= 0)
        {
            currentOxygen = 0;
            currentHealth -= (float) 0.05;
        }

        // Update HealthBar
        healthBar.UpdateBar(currentHealth, maxHealth);
        oxygenBar.UpdateBar(currentOxygen, maxOxygen);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Handheld.Vibrate();
        currentHealth = 0;
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        Destroy(player);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void HealPlayer()
    {
        // Increase the current health by 50%.
        currentHealth += (maxHealth / 2);
        // If the current health is greater than max, then set it to max.
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        // Update health bar.
        healthBar.UpdateBar(currentHealth, maxHealth);
    }

    public void TakeDamage(int damage)
    {
        // If player can't take damage, then return.
        if (canTakeDamage == false)
            return;

        currentHealth -= damage;
        FindObjectOfType<AudioManager>().Play("TakeDamage");

        //If health is less than zero
        if (currentHealth <= 0)
        {
            Die();
        }

        //Update the Health Bar.
        healthBar.UpdateBar(currentHealth, maxHealth);
    }

    public void Breathe()
    {
        // Update Oxygen 
        currentOxygen = 100;
       // Update Oxygen Bar
        oxygenBar.UpdateBar(currentOxygen, maxOxygen);
    }
}
