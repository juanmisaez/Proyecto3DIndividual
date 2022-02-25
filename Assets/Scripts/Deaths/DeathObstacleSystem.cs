using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObstacleSystem : DeathSystem
{
    protected override void Dead()
    {
        gameObject.SetActive(false);
    }
}