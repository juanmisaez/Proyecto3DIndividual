using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionEnlistSystem : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        other.gameObject.GetComponent<WriteNumSoldierSystem>()?.NewSoldier();
    }
}