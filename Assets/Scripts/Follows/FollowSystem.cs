using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowSystem : MonoBehaviour // de los soldados
{
    public event Action<bool> FollowPlayer = delegate { }; // Al MenuSystem

    public bool follow;

    public void Follow(int i)
    {
        if(i == 1)
        {
            follow = true;
            FollowPlayer(follow);
        }
    }
}