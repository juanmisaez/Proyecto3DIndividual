using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeathSystem : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<HealthSystem>().Death += Dead;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Death -= Dead;
    }

    private void Dead()
    {
        gameObject.SetActive(false);
    }
}