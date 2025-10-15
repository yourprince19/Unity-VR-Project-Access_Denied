using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public HP health;
    public Image Fill;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fill.fillAmount = health.currentHealth / health.maxHealth;
    }
}
