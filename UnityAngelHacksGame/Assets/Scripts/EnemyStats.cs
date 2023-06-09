using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float health, maxHealth;

    [SerializeField] Healthbar healthbar;

    private MoneyManager mm;

    private void Start()
    {
        health = maxHealth;
        healthbar = GetComponentInChildren<Healthbar>();
        healthbar.UpdateHealthBar(health, maxHealth);

        mm = FindObjectOfType<MoneyManager>().GetComponent<MoneyManager>();
    }

    public void TakeDmg(float amount)
    {
        health -= amount;
        healthbar.UpdateHealthBar(health, maxHealth);

        if (health <= 0)
        {
            Instantiate(mm.coin, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
