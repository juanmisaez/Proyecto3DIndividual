using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private Animator _anim;
    private InputSystemKeyboard _input;

    public float speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        _input = GetComponent<InputSystemKeyboard>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        //_anim.SetBool("run", true);

        _rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (_input.hor != 0)
        {
            transform.Translate(Vector3.right * speed * _input.hor * Time.deltaTime);
        }
    }
}