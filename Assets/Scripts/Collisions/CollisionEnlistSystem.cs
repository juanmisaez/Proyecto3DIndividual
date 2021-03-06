using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionEnlistSystem : CollisionSystem // soldados
{
    FollowSystem follow;

    private void Start()
    {
        follow = gameObject.GetComponent<FollowSystem>();
    }

    protected override void OnCollision(Collision other)
    {
        if (other.gameObject.tag.Equals("Player") && follow.follow == false)
        {
            WriteNumSoldierSystem.AddToList(gameObject.GetComponent<SoldierController>()); // se manda a si mismo como el Controlador
        }
    }
}