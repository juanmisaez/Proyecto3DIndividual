using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{
    private Rigidbody _rb;

    public float speedCharge = 16;
    public float speedFollow = 8;
    public float stoppingDistance = 2;
    bool attack;
    bool follow;

    public Transform player;
    GameObject target;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (attack)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speedCharge * Time.deltaTime);
        }
        else if (follow && Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speedFollow * Time.deltaTime);
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