using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CanvasUpdate : MonoBehaviour
{
    public static event Action<int> HealthUpdate = delegate { };
    public static event Action/*<int>*/ NumSoldierUpdate = delegate { };

    private void UpdateHealth(int health)
    {
        HealthUpdate(health);
    }

    private static void UpdateNumSoldier(/*int numSoldier*/)
    {
        NumSoldierUpdate(/*numSoldier*/);
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().LifeUpdated += UpdateHealth;
        WriteNumSoldierSystem.SoldierUpdated += UpdateNumSoldier;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().LifeUpdated -= UpdateHealth;
        WriteNumSoldierSystem.SoldierUpdated -= UpdateNumSoldier;
    }
}