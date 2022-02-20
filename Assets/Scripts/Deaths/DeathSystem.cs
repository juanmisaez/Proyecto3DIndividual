using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeathSystem : MonoBehaviour
{
    protected virtual void Dead()
    {
        gameObject.SetActive(false);
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().Death += Dead;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Death -= Dead;
    }
}