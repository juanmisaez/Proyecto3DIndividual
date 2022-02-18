using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchOrc : MonoBehaviour
{
    public float speed = 16;
    public float goDistance = 25;

    GameObject[] soldiers; //la tendría que obtener de otro lugar, cuando se unen se va expandiendo

    public Transform orc; // un ARRAY habrán más de uno o bien mediante LAYER o TAG

    // Filtrar que solo vaya UN soldado una vez el orco ha sido visualizado
    // y a su vez, que deje de seguir al player

    void Update()
    {
        if (Vector3.Distance(transform.position, orc.position) < goDistance)
        {
            for(int s = 0; s < soldiers.Length; s++)
            {
                if(GetComponent<SoldierController>().attack == false)
                {
                    GetComponent<SoldierController>().attack = true;
                    transform.position = Vector3.MoveTowards(transform.position, orc.position, speed * Time.deltaTime);
                    break;
                }
            }
        }
    }
}