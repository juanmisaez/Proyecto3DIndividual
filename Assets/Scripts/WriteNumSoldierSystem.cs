using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class WriteNumSoldierSystem
{
    public static event Action SoldierUpdated = delegate { };

    public static List<SoldierController> soldiersList = new List<SoldierController>();

    public static void AddToList(SoldierController _soldier)
    {
        soldiersList.Insert(0, _soldier);
        SoldierUpdated();
    }
    public static void RemoveToList(SoldierController _soldier)
    {
        soldiersList.Remove(_soldier);
        SoldierUpdated();
    }

    public static void ClearList()
    {
        soldiersList.Clear();
    }

    public static int GetNumSoldier()
    {
        return soldiersList.Count;
    }
}