using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class WriteNumSoldierSystem
{
    public static event Action<int> SoldierUpdated = delegate { };

    public static List<SoldierController> soldiersList = new List<SoldierController>();

    private static int numSoldier = 0;

    public static void ModifySoldierNum(int toAdd)
    {
        numSoldier += toAdd;

        if (numSoldier <= 0)
            numSoldier = 0;

        SoldierUpdated(GetNumSoldier());
    }

    public static void AddToList(SoldierController _soldier)
    {
        soldiersList.Insert(0, _soldier);
    }
    public static void RemoveToList(SoldierController _soldier)
    {
        soldiersList.Remove(_soldier);
    }

    public static int GetNumSoldier()
    {
        return numSoldier;
    }
}