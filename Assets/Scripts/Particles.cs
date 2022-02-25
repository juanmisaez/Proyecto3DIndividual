using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem particle;

    public void PlayParticle(Vector3 position)
    {
        Instantiate(particle, position, Quaternion.Euler(0, 0, 0));
    }

    private void OnEnable()
    {
        GetComponent<SoldierController>().PlayParticle += PlayParticle;        
    }
    private void OnDisable()
    {
        GetComponent<SoldierController>().PlayParticle -= PlayParticle;
    }
}