using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoldierController : MonoBehaviour
{
    public event Action<Vector3> PlayParticle = delegate { }; // Al Particle
    public event Action StopParticle = delegate { }; // Al Particle

    private Animator _anim;
    private MoveSystem _move;
    private CapsuleCollider _capsuleCollider;
    private PlaySoundSystem _playSound;

    public float speedCharge;
    public float stoppingDistance;

    bool attack;
    bool follow;
    bool charge;

    public Transform player;
    GameObject target;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _move = GetComponent<MoveSystem>();
        _capsuleCollider = GetComponent<CapsuleCollider>();
        _playSound = GetComponent<PlaySoundSystem>();
    }

    void Update()
    {
        if (attack && !charge)
        {
            PlayParticle(gameObject.transform.position);
            _move.ChargeOrc(target, speedCharge);
        }
        else if (follow && charge)
        {
            PlayParticle(gameObject.transform.position);
            _move.ChargeForward(speedCharge);
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
        _anim.SetBool("follow", true);
    }

    public void Charge()
    {
        charge = true;
    }

    void Hit()
    {
        _playSound.PlaySound("Soldier", "SoldierHit");
        _anim.SetBool("hit", true);
        _capsuleCollider.enabled = false;
        attack = false;
        follow = false;
        StopParticle();
    }

    void OnEnable()
    {
        GetComponent<FollowSystem>().FollowPlayer += Follow;
        GetComponent<HealthSystem>().Hit += Hit;
    }

    void OnDisable()
    {
        GetComponent<FollowSystem>().FollowPlayer -= Follow;
        GetComponent<HealthSystem>().Hit -= Hit;
    }
}