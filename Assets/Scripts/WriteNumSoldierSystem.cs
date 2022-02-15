using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WriteNumSoldierSystem : MonoBehaviour
{
    public event Action<int> SoldierUpdated = delegate { };

    private int numSoldier = 0;

    private void Start()
    {
        SoldierUpdated(GetNumSoldier());
    }

    public void NewSoldier()
    {
        numSoldier += 1;
        SoldierUpdated(GetNumSoldier());
    }

    public void DeadSoldier()
    {
        numSoldier -= 1;
        SoldierUpdated(GetNumSoldier());
    }

    public int GetNumSoldier()
    {
        return numSoldier;
    }
}