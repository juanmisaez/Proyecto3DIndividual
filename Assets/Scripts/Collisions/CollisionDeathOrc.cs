using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionDeathOrc : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.tag == "Orc")
        {
            other.gameObject.GetComponent<HealthSystem>()?.ReduceHealth(value);
        }
    }
}