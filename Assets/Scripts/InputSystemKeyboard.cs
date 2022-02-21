using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{
    public static event Action Paused = delegate { }; // Al MenuSystem

    public float hor { get; private set; }
    public bool escape { get; private set; }
    public bool space { get; private set; }

    bool over;

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        escape = Input.GetKeyDown(KeyCode.Escape);
        space = Input.GetKeyDown(KeyCode.Space);

        if (escape && over == false)
        {
            Paused();
        }
        if(space)
        {
            WriteNumSoldierSystem.soldiersList[0].Charge();
        }
    }

    void Over(bool _over)
    {
        over = _over;
    }

    void OnEnable()
    {
        MenuSystem.IsOver += Over;
    }
    void OnDisable()
    {
        MenuSystem.IsOver -= Over;
    }
}