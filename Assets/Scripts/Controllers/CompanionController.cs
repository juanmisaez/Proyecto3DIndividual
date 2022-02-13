using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionController : MonoBehaviour
{
    private InputSystemKeyboard _input;
    private CharacterController _controller;


    public float speed;
    public float gravity = -9.81f; // falta terminar

    Vector3 velocity;

    private void Awake()
    {
        _input = GetComponent<InputSystemKeyboard>();
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        _controller.Move(transform.forward * speed * Time.deltaTime);

        if (_input.hor != 0)
        {
            _controller.Move(Vector3.right * speed * _input.hor * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;

        _controller.Move(velocity * Time.deltaTime);
    }
}