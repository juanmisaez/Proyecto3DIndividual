using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private Rigidbody _rb;

    public float speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void MoveForward() // Player
    {
        _rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveBack() // RollingLog
    {
        _rb.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    public void MoveRight(InputSystemKeyboard _input) // Player
    {
        _rb.transform.Translate(Vector3.right * speed * _input.hor * Time.deltaTime);
    }

    public void FollowPlayer(Transform _player) // Soldier
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.position, speed * Time.deltaTime);
    }

    public void ChargeOrc(GameObject _target, float _speedCharge) // Soldier
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speedCharge * Time.deltaTime);
    }
}
