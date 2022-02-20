using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FinishSystem : MonoBehaviour
{
    public static event Action PlayerWin = delegate { }; // Al MenuSystem
    public static event Action PlayerDead = delegate { }; // Al MenuSystem

    public void Victory()
    {
        Debug.Log("Has ganado!");
        GetComponent<MoveSystem>().speed = 0;
        PlayerWin();
    }

    public void GameOver()
    {
        Debug.Log("Has perdido");
        PlayerDead();
    }
}