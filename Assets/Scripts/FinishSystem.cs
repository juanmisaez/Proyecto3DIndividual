using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishSystem : MonoBehaviour
{
    public void Victory()
    {
        Debug.Log("Has ganado!");
        GetComponent<MoveSystem>().speed = 0;
    }

    public void GameOver()
    {
        Debug.Log("Has perdido");
    }
}