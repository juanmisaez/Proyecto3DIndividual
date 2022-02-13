using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionFollowSystem : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        other.gameObject.GetComponent<FollowSystem>()?.Follow(value);
    }
}