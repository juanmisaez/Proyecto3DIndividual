using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSystem : MonoBehaviour
{
    public float speed = 10;
    public float stoppingDistance = 2;

    public Transform player;

    private bool follow;

    void Update()
    {        
        if(follow && Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    public void Follow(int i)
    {
        if(i == 1)
        {
            follow = true;
        }
    }
}