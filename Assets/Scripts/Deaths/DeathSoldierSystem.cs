using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSoldierSystem : DeathSystem
{
    //[SerializeField]
    //Transform player;

    protected override void Dead()
    {
       // player.gameObject.GetComponent<WriteNumSoldierSystem>().DeadSoldier();

        WriteNumSoldierSystem.ModifySoldierNum(-1);

        gameObject.SetActive(false);
    }
}