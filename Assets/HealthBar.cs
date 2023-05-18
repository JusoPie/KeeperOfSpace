using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Image healthBarImage;
    public PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    public void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(playerHealth.currentHealth / playerHealth.maxHealth, 0, 100f);
    }

    public void SetHealth(int hp)
    {
        healthBarImage.fillAmount = hp;
    }
}
