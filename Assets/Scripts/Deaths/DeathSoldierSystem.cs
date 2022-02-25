using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSoldierSystem : DeathSystem
{
    protected override void Dead()
    {
        WriteNumSoldierSystem.RemoveToList(gameObject.GetComponent<SoldierController>()); // se manda a si mismo como el Controlador
        gameObject.GetComponent<FollowSystem>()?.Follow(0);
    }
}