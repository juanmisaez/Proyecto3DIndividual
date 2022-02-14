using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSystem : MonoBehaviour
{
    //private bool follow;

    /*public Transform player;

    public float followSpeed = 5;
    public float followDistance = 3;
    public float tolerance = 0.1f;

    public float margenX = 2;
    public float margenY = 0;

    Vector3 playerOffset;
    Vector3 playerOffsetProjected;
    Vector3 playerOffsetNormalized;
    float distance;*/

    void Update()
    {
        
        /*playerOffset = player.position - transform.position;
        playerOffset = new Vector3(playerOffset.x - margenX, playerOffset.y, playerOffset.z);

        distance = playerOffset.magnitude;

        if (distance < followDistance && distance > tolerance)
        {
            playerOffsetProjected = new Vector3(playerOffset.x, playerOffset.y, playerOffset.z);
            playerOffsetNormalized = playerOffsetProjected.normalized;

            transform.position += playerOffsetNormalized * followSpeed * Time.deltaTime;
        }*/
    }

    public void Follow(int i)
    {
        if(i == 1)
        {
            //follow = true;
            TeamUp();
        }
    }

    void TeamUp()
    {
        gameObject.GetComponent<InputSystemKeyboard>().enabled = true;
        gameObject.GetComponent<CompanionController>().enabled = true;
    }
}