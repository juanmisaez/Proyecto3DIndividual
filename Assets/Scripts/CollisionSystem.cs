using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionSystem : MonoBehaviour
{
    [SerializeField]
    private int damage;

    private void OnCollisionEnter(Collision collision)
    {
        OnCollision(collision);
    }

    protected virtual void OnCollision(Collision other)
    {
        other.gameObject.GetComponent<HealthSystem>()?.ReduceHealth(damage);

    }
}