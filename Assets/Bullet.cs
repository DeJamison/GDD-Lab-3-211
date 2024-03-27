using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 100; // Damage value of the bullet

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object collided with is an enemy
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            // Reduce enemy health
            enemy.TakeDamage(damage);

            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}

