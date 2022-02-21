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
        //WriteNumSoldierSystem.ModifySoldierNum(-1);

        WriteNumSoldierSystem.RemoveToList(gameObject.GetComponent<SoldierController>()); // se manda a si mismo como el Controlador
        gameObject.SetActive(false);
    }
}