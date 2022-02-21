using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthSystem : MonoBehaviour
{
    public event Action Death = delegate { };
    public event Action<int> LifeUpdated = delegate { };
    public event Action<int> MaxLifeUpdated = delegate { };
    public event Action Stumble = delegate { };

    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int health;

    private void Start()
    {
        LifeUpdated(GetHealth());
        MaxLifeUpdated(GetMaxHealth());
    }        

    public void ReduceHealth(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
            LifeUpdated(GetHealth());
            Death(); 
        }
        else
        {
            LifeUpdated(GetHealth());
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

    public int GetMaxHealth()
    {
        return maxHealth;
    }
} 