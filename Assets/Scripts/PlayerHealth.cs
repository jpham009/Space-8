
using UnityEngine;
using System.Collections;


public class PlayerHealth : MonoBehaviour
{
    static PlayerHealth instance;
    public static PlayerHealth Instance { get { return instance; } }
    bool canTakeDamage = true;

    public int maxHealth = 100;
    public float currentHealth;
    public float invulnerabilityTime = 0.5f;
    public Camera cam;
    public GameObject player;

    public SimpleHealthBar healthBar;


    void Awake()
    {
        // If the instance variable is already assigned, then there are multiple player health scripts in the scene. Inform the user.
        if (instance != null)
            Debug.LogError("There are multiple instances of the Player Health script. Assigning the most recent one to Instance.");

        // Assign the instance variable as the Player Health script on this object.
        instance = GetComponent<PlayerHealth>();
    }

    void Start()
    {
        // Set the current health and shield to max values.
        currentHealth = maxHealth;

        // Update the Simple Health Bar with the updated values of Health and Shield.
        healthBar.UpdateBar(currentHealth, maxHealth);

    }

    void Update()
    {
        // Testing playerHealth 
        currentHealth -= (float) 0.05;

        // Update HealthBar
        healthBar.UpdateBar(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            //Set the current health to zero.
            currentHealth = 0;
            //Destroy(player);
            // ShakeCamera();
        }
    }

    public void HealPlayer()
    {
        // Increase the current health by 25%.
        currentHealth += (maxHealth / 4);

        // If the current health is greater than max, then set it to max.
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        // Update the Simple Health Bar with the new Health values.
        healthBar.UpdateBar(currentHealth, maxHealth);
    }

    public void TakeDamage(int damage)
    {
        // If the player can't take damage, then return.
        if (canTakeDamage == false)
            return;

        currentHealth -= damage;

        //If the health is less than zero...
        if (currentHealth <= 0)
        {
            //Set the current health to zero.
            currentHealth = 0;

            //Run the Death function since the player has died.
            //Death();
            Destroy(player);
        }

        // Set canTakeDamage to false to make sure that the player cannot take damage for a brief moment.
        canTakeDamage = false;

        //Update the Health and Shield status bars.
        healthBar.UpdateBar(currentHealth, maxHealth);

    }
}

/* for reference.... 

        //void Death()
        //{
        //    // Show the death screen, and disable the player's control.
        //    GameManager.Instance.ShowDeathScreen();
        //    GetComponent<PlayerController>().canControl = false;

        //    // Destroy this game object.
        //    Destroy(gameObject);
        //}

        //IEnumerator Invulnerablilty()
        //{
        //    // Wait for the invulnerability time variable.
        //    yield return new WaitForSeconds(invulnerabilityTime);
        //    // Then allow the player to take damage again.
        //    canTakeDamage = true;
        //}
*/
