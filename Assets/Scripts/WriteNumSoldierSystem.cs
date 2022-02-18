using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class WriteNumSoldierSystem
{
    public static event Action<int> SoldierUpdated = delegate { };

    private static int numSoldier = 0;

    public static void ModifySoldierNum(int toAdd)
    {
        numSoldier += toAdd;

        if (numSoldier <= 0)
            numSoldier = 0;

        SoldierUpdated(GetNumSoldier());
    }

    //public void NewSoldier()
    //{
    //    numSoldier += 1;
    //    SoldierUpdated(GetNumSoldier());
    //}

    //public void DeadSoldier()
    //{
    //    numSoldier -= 1;
    //    if (numSoldier <= 0)
    //        numSoldier = 0;
    //    SoldierUpdated(GetNumSoldier());
    //}

    public static int GetNumSoldier()
    {
        return numSoldier;
    }
}