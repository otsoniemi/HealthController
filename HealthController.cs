using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    // The maximum health of the character
    public int maxHealth = 100;

    // The current health of the character
    public int currentHealth;

    // The UI text element that displays the character's health
    public Text healthText;

    void Start()
    {
        // Set the initial health of the character
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    void Update()
    {
        // Check if the character is dead
        if (currentHealth <= 0)
        {
            // Handle character death
            // ...
        }
    }

    public void TakeDamage(int damage)
    {
        // Reduce the character's health by the specified amount of damage
        currentHealth -= damage;

        // Update the character's health on the UI
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        // Set the text of the healthText element to the character's current health
        healthText.text = currentHealth.ToString();
    }
}
