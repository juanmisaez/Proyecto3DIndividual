using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _anim;
    private InputSystemKeyboard _input;
    private MoveSystem _move;
    private PlaySoundSystem _playSound;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _input = GetComponent<InputSystemKeyboard>();
        _move = GetComponent<MoveSystem>();
        _playSound = GetComponent<PlaySoundSystem>();
    }

    void Update()
    {
        _move.MoveForward();

        if (_input.hor != 0)
        {
            _move.MoveRight(_input);
        }
    }

    void Stumble()
    {
        _anim.SetBool("hit", true);
        _playSound.PlaySound("Player", "PlayerHurt");
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().Hit += Stumble;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Hit -= Stumble;
    }
}