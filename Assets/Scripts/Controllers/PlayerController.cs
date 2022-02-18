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

        WriteNumSoldierSystem.ModifySoldierNum(0);
    }

    void Update()
    {
        _rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (_input.hor != 0)
        {
            _rb.transform.Translate(Vector3.right * speed * _input.hor * Time.deltaTime);
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