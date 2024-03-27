using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5; // Initial health of the enemy

    public void TakeDamage(int damageAmount)
    {
        // Reduce enemy health
        health -= damageAmount;

        // Check if the enemy's health has reached zero or below
        if (health <= 0)
        {
            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}
