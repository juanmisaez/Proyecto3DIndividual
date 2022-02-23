using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowSystem : MonoBehaviour // de los soldados
{
    public event Action<bool> FollowPlayer = delegate { };

    public bool follow;

    public void Follow(int i) // le llega por el CollisionFollowSystem del player
    {
        if(i == 1)
        {
            follow = true;
            FollowPlayer(follow);
        }
        else
        {
            follow = false;
            FollowPlayer(follow);
        }
    }
}