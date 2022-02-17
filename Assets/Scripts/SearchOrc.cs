using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchOrc : MonoBehaviour
{
    public float speed = 16;
    public float goDistance = 25;

    public Transform orc;

    // Filtrar que solo vaya un soldado una vez el orco ha sido visualizado
    // y a su vez, que deje de seguir al player

    void Update()
    {
        if (Vector3.Distance(transform.position, orc.position) < goDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, orc.position, speed * Time.deltaTime);
        }
    }
}