using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingLog : MonoBehaviour
{
    private Rigidbody _rb;
    private InputSystemKeyboard _input;

    public float speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _input = GetComponent<InputSystemKeyboard>();
    }

    void Update()
    {
        _rb.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}