using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystemKeyboard : MonoBehaviour
{
    public float hor { get; private set; }

    void Start()
    {
        
    }

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
    }
}