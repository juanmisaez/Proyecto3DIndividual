using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcController : MonoBehaviour
{
    private Animator _anim;
    private BoxCollider _boxCollider;
    private PlaySoundSystem _playSound;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider>();
        _playSound = GetComponent<PlaySoundSystem>();
    }

    void Hurt()
    {
        _playSound.PlaySound("Orc", "OrcHurt");
        _anim.SetBool("hit", true);
        _boxCollider.enabled = false;
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().Hit += Hurt;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().Hit -= Hurt;
    }
}
