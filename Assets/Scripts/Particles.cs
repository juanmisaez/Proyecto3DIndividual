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

    public void StopParticle()
    {
        //Destroy(particle);
    }

    private void OnEnable()
    {
        GetComponent<SoldierController>().PlayParticle += PlayParticle;
        GetComponent<SoldierController>().StopParticle += StopParticle;
    }
    private void OnDisable()
    {
        GetComponent<SoldierController>().PlayParticle -= PlayParticle;
        GetComponent<SoldierController>().StopParticle -= StopParticle;
    }
}