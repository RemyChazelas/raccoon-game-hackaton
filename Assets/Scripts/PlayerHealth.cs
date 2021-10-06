// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

public HealthBar healthBar;

    void Start()
    {
        
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        } 
    }
    // public 
    void TakeDamage(int damage)
    {
        // if (!isInvincible)
        // {
            // AudioManager.instance.PlayClipAt(hitSound, transform.position);
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

            // if(currentHealth <= 0)
            // {
            //     Die();
            //     return;
            // }

            // isInvincible = true;
            // StartCoroutine(InvincibilityFlash());
            // StartCoroutine(HandleInvincibilityDelay());
        // }
    }
}
