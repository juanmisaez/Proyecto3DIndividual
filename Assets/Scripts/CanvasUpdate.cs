using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CanvasUpdate : MonoBehaviour
{
    public static event Action<int> HealthUpdate = delegate { };

    private void UpdateHealth(int health)
    {
        HealthUpdate(health);
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().LifeUpdated += UpdateHealth;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().LifeUpdated -= UpdateHealth;
    }
}