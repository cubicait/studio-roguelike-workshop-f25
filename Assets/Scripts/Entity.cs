using UnityEngine;

public class Entity : MonoBehaviour
{
    //variables
    public int maxHealth = 10;
    public int currentHealth;
    private bool isDead = false; //private. only this script can access it

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void TakeDamage(int damage) 
    {
        if (isDead) return; //if already dead, do nothing

        currentHealth -= damage;
        if (currentHealth <= 0) {
            Die();
        }
    }

    public void Die() 
    {
        isDead = true;
        Destroy(gameObject); //deletes the game object from the scene in game
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
