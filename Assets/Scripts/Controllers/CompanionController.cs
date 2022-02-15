using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionController : MonoBehaviour
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
        _rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (_input.hor != 0)
        {
            _rb.transform.Translate(Vector3.right * speed * _input.hor * Time.deltaTime);
        }
    }
}