using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{
    public static event Action Paused = delegate { }; // Al MenuSystem

    public float hor { get; private set; }
    public bool escape { get; private set; }

    bool over;

    void Start()
    {
        
    }

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        escape = Input.GetKeyDown(KeyCode.Escape);

        if (escape && over == false)
        {
            Paused();
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