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
    public event Action Hit = delegate { };

    public static bool modeInvincible;

    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int health;

    private void Start()
    {
        LifeUpdated(GetHealth());
        MaxLifeUpdated(GetMaxHealth());
    }        
    /// <summary>
    /// Reduce la vida
    /// </summary>
    /// <param name="damage">aaa</param>
    public void ReduceHealth(int damage)
    {
        health -= damage;

        //--Player_Invulnerable--

        if (/*CheatsSystem.modeInvincible*/modeInvincible && gameObject.tag == "Player")
        {
            health += damage;
        }

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

        if(damage > 0)
        {
            Hit();
        }        
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