using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGoal : CollisionSystem
{
    protected override void OnCollision(Collision other)
    {
        if(WriteNumSoldierSystem.GetNumSoldier() < value)
            other.gameObject.GetComponent<FinishSystem>()?.GameOver();
        else
            other.gameObject.GetComponent<FinishSystem>()?.Victory();

        if (other.gameObject.tag == "Soldier")
        {
            other.gameObject.GetComponent<MoveSystem>().speed = 0;
        }
    }
}