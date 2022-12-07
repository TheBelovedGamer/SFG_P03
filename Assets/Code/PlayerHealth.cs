using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //variables
    private float health;
    private float lerpTimer;
    public float maxHealth = 100f;
    public float chipSpeed = 2f;

    public Image frontHealthBar;
    public Image healthBarChange;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);

        UpdateHealthUI();

        //testing purposes
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("ouch");
            TakeDamage(5);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("heal!");
            Heal(5);
        }
    }

    public void UpdateHealthUI()
    {
        Debug.Log(health);

        float fillFront = frontHealthBar.fillAmount;
        float fillChange = healthBarChange.fillAmount;
        float hFraction = health / maxHealth;

        if(fillChange > hFraction)
        {
            frontHealthBar.fillAmount = hFraction;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            healthBarChange.fillAmount = Mathf.Lerp(fillChange, hFraction, percentComplete);
        }

        if (fillFront < hFraction)
        {
            healthBarChange.fillAmount = hFraction;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            frontHealthBar.fillAmount = Mathf.Lerp(fillFront, healthBarChange.fillAmount, percentComplete);
        }
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        lerpTimer = 0f;
        healthBarChange.color = Color.red;
    }

    public void Heal(float healAmount)
    {
        health += healAmount;
        lerpTimer = 0f;
        healthBarChange.color = Color.yellow;
    }
}
