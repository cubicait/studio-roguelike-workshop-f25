using UnityEngine;

public class Entity : MonoBehaviour
{
    //variables
    public int MaxHealth = 10;
    public int CurrentHealth;
    private bool dead = false; //private. only this script can access it
    [SerializeField] public int MovementSpeed = 2;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (dead) return; //if already dead, do nothing

        CurrentHealth -= damage;

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        dead = true;
        Destroy(gameObject); //deletes the game object from the scene in game
    }
}
