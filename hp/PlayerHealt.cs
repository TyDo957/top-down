using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealt : MonoBehaviour
{
    /*
    private float health = 0f;
    [SerializeField] public float maxHealth = 100f;
    public Image healthBar;
    private bool isDead = false;
    public Image damageScreen;
    Color alphaColor;
    public GameObject gameOverCanvas; // Tham chiếu đến Canvas Game Over
    public float delayTime = 5.0f;
    private Vector3 respawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        respawnPosition = transform.position;
        alphaColor = damageScreen.color;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = math.clamp(health / maxHealth, 0, 5);
    }
    public void UpdateHealth(float mod)
    {
        health += mod;
        alphaColor.a += .1f;
        damageScreen.color = alphaColor;
        if (health > maxHealth)
        {
            health = maxHealth;
           
        }
        else if(health <= 0f)
        {
            transform.position = respawnPosition;
            isDead = true;
            health = 0f;
            Debug.Log("Player respawn");
            gameOverCanvas.SetActive(true); // Show Game Over screen
            Invoke("HideGameOver", delayTime);

        }
    }

    public void ReceiveDamage(float damage) // Hàm nhận sát thương
    {
        health -= damage;
        UpdateHealth(health); // Call UpdateHealth to handle health changes
    }

    private void HideGameOver()
    {
        gameOverCanvas.SetActive(false); // Hide Game Over screen
        isDead = false; // Reset death state for next gameplay loop
    }
    */
    private float health = 0f;
    public float maxHealth = 100f;
    private bool isDead = false;
    public Image healthBar;

    public GameObject gameOverCanvas; // Tham chiếu đến Canvas Game Over
    public float delayTime = 5.0f;

    // Reference for the player's initial position
    private Vector3 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        respawnPosition = transform.position; // Store initial position
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0f, 1f); // Ensure fillAmount is between 0 and 1
    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f && !isDead)
        {
            isDead = true;
            health = 0f;

            Debug.Log("Player Died"); // More descriptive message

            // Respawn logic (choose one or both methods):

            // Method 1: Reset position to initial spawn point
            transform.position = respawnPosition;

            // Method 2: Implement a dedicated respawn system (if applicable)
            // Replace with your respawn logic (e.g., calling a respawn function)

            gameOverCanvas.SetActive(true); // Show Game Over screen
            Invoke("HideGameOver", delayTime);
        }
    }

    public void ReceiveDamage(float damage) // Hàm nhận sát thương
    {
        health -= damage;
        UpdateHealth(health); // Call UpdateHealth to handle health changes
    }

    private void HideGameOver()
    {
        gameOverCanvas.SetActive(false); // Hide Game Over screen
        isDead = false; // Reset death state for next gameplay loop
    }
}


