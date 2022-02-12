using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthSystem : MonoBehaviour
{
    public event Action Death = delegate { };
    public event Action<int> LifeUpdated = delegate { };
    public event Action Stumble = delegate { };

    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int health;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Start()
    {
        LifeUpdated(GetHealth());
    }

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

    public void ReduceHealth(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            LifeUpdated(health);
            Death(); 
        }
        else
        {
            LifeUpdated(health);
        }
        Stumble();
    }

    public void OnEnable()
    {
        health = maxHealth;
    }

    public int GetHealth()
    {
        return health;
    }
} 