using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFollowSystem : CollisionSystem // del player
{
    protected override void OnCollision(Collision other)
    {
        if(other.gameObject.GetComponent<FollowSystem>().follow == false) // No funciona
        {
            other.gameObject.GetComponent<FollowSystem>()?.Follow(value);
        }
    }
}