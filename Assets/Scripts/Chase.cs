using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
    Vector3 dest;
    public AudioSource chaseSound;

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
    }
}
