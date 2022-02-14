using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    private int maxHealth;
    private int health;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        if (health > maxHealth)
            health = maxHealth;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].sprite = fullHeart;
            else
                hearts[i].sprite = emptyHeart;

            if (i < maxHealth)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
    }

    private void UpdateHealth(int _health)
    {
        health = _health;
    }
    private void UpdateMaxHealth(int _maxHealth)
    {
        maxHealth = _maxHealth;
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().LifeUpdated += UpdateHealth;
        GetComponent<HealthSystem>().MaxLifeUpdated += UpdateMaxHealth;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().LifeUpdated -= UpdateHealth;
        GetComponent<HealthSystem>().MaxLifeUpdated -= UpdateMaxHealth;
    }
}