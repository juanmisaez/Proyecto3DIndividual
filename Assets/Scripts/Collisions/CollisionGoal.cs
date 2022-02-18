using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGoal : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        other.gameObject.GetComponent<FinishSystem>()?.Victory();
    }
}