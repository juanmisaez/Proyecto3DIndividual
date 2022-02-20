using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingLogController : MonoBehaviour
{
    private MoveSystem _move;

    private void Awake()
    {
        _move = GetComponent<MoveSystem>();
    }

    void Update()
    {
        _move.MoveBack();
        //_rb.transform.Rotate(-5,0,0);
    }
}