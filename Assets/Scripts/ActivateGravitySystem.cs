using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGravitySystem : MonoBehaviour
{
    private Rigidbody _rb;
    public Transform player;

    public float fallDistance = 5;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < fallDistance)
        {
            _rb.useGravity = true;
        }
    }
}