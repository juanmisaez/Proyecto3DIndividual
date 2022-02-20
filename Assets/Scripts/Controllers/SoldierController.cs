using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{
    private MoveSystem _move;

    public float speedCharge;
    public float stoppingDistance;

    bool attack;
    bool follow;

    public Transform player;
    GameObject target;

    private void Awake()
    {
        _move = GetComponent<MoveSystem>();
    }

    void Update()
    {
        if (attack)
        {
            _move.ChargeOrc(target, speedCharge);
        }
        else if (follow && Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            _move.FollowPlayer(player);
        }
    }

    public void Attack(GameObject _orc)
    {
        attack = true;
        target = _orc;
    }

    void Follow(bool _follow)
    {
        follow = _follow;
    }

    private void OnEnable()
    {
        GetComponent<FollowSystem>().FollowPlayer += Follow;
    }
}