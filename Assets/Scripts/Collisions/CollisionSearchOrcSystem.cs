using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSearchOrcSystem : MonoBehaviour
{    
    public GameObject[] orc;
        
    private void OnTriggerEnter(Collider other)
    {
        for (int s = 0; s < orc.Length; s++)
        {
            if (other.gameObject == orc[s])
            {
                Charge(orc[s]);
            }
        }            
    }

    void Charge(GameObject _orc)
    {        
        WriteNumSoldierSystem.soldiersList[0].Attack(_orc);
    }
}