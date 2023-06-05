using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float health, maxHealth;

    [SerializeField] Healthbar healthbar;
    [SerializeField] private GameManager gameManager;

    private void Start()
    {
        healthbar = GetComponentInChildren<Healthbar>();
        healthbar.UpdateHealthBar(health, maxHealth);
    }

    public void TakeDmg(float amount)
    {
        health -= amount;
        healthbar.UpdateHealthBar(health, maxHealth);

        if (health <= 0)
        {
            gameManager.Lose();
        }
    }
}
