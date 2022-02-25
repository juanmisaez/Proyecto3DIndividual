using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;

[ExecuteInEditMode()]

public class CheatsSystem : MonoBehaviour
{
    [MenuItem("Implemented Cheats/Player invencible &#i", false, 1)] // & = alt, # = shit, i
    public static void ModeInvincible()
    {
        HealthSystem.modeInvincible = true;
    }

    [MenuItem("Implemented Cheats/Add companion &#o", false, 1)] // & = alt, # = shit, o
    public static void AddCompanion()
    {
        
    }

    [MenuItem("Implemented Cheats/Remove companion &#p", false, 1)] // & = alt, # = shit, p
    public static void RemoveCompanion()
    {
        
    }

    [MenuItem("Implemented Cheats/Select level 1 &#1", false, 1)] // & = alt, # = shit, 1
    public static void SelectLevel1()
    {
        SceneManager.LoadScene("GameLevel1");
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    [MenuItem("Implemented Cheats/Select level 2 &#2", false, 1)] // & = alt, # = shit, 2
    public static void SelectLevel2()
    {
        SceneManager.LoadScene("GameLevel2");
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    [MenuItem("Implemented Cheats/Select level 3 &#3", false, 1)] // & = alt, # = shit, 3
    public static void SelectLevel3()
    {
        SceneManager.LoadScene("GameLevel3");
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }
}