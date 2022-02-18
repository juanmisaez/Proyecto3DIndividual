using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour
{
    private Rigidbody _rb;

    public bool attack;

    public float speed = 16;
    public float goDistance = 25;

    public GameObject[] soldiers;
    public GameObject orc; // un ARRAY habrán más de uno o bien mediante LAYER o TAG

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, orc.transform.position) < goDistance)
        {
            SearchOrc();
        }
    }

    void SearchOrc()
    {
        for (int s = 0; s < soldiers.Length; s++)
        {
            Debug.Log("soldado numero " + s + " ataca!"); //---<

            transform.position = Vector3.MoveTowards(transform.position, orc.transform.position, speed * Time.deltaTime);
        }
    }
}