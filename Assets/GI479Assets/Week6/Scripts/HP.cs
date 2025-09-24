using UnityEngine;
using UnityEngine.Events;

public class HP : MonoBehaviour
{
    public float maxHealth = 100;

    public UnityEvent OnTakeDamage;
    public UnityEvent OnDead;

    private float currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;

    }
    
    public void TakeDamage(float damageAmount)
    {
        if(!IsDead())
        {
            OnTakeDamage.Invoke();
            currentHealth -= damageAmount;

            if(IsDead())
            {
                OnDead.Invoke();
            }
        }
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }
}
