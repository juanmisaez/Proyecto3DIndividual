using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFollowSystem : CollisionSystem // del player
{
    protected override void OnCollision(Collision other)
    {
        other.gameObject.GetComponent<FollowSystem>()?.Follow(value);
    }
}