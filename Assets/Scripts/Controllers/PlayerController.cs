using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _anim;
    private InputSystemKeyboard _input;
    private MoveSystem _move;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _input = GetComponent<InputSystemKeyboard>();
        _move = GetComponent<MoveSystem>();
    }

    void Update()
    {
        _move.MoveForward();

        if (_input.hor != 0)
        {
            _move.MoveRight(_input);
        }
    }

    void Tripping()
    {
        _anim.SetBool("hit", true);
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().Stumble += Tripping;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Stumble -= Tripping;
    }
}