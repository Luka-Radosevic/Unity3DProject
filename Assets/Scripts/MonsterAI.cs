using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent ai;
    public Animator aiAnimator;
    int randNum;
    public Transform playerTransform, aiTransform, randDest1, randDest2, randDest3, randDest4, randDest5, randDest6, randDest7, randDest8;
    public bool idle, walking, running;
    Vector3 dest;
    public float chaseDuration, idleDuration;

    void Start()
    {
        walking = true;
        randNum = Random.Range(0, 8);
        aiAnimator.SetTrigger("walk");

        if(randNum == 0)
        {
            dest = randDest1.position;
        }

        if(randNum == 1)
        {
            dest = randDest2.position;
        }

        if(randNum == 2)
        {
            dest = randDest3.position;
        }

        if(randNum == 3)
        {
            dest = randDest4.position;
        }

        if(randNum == 4)
        {
            dest = randDest5.position;
        }

        if(randNum == 5)
        {
            dest = randDest6.position;
        }

        if(randNum == 6)
        {
            dest = randDest7.position;
        }

        if(randNum == 7)
        {
            dest = randDest8.position;
        }
    }

    void Update()
    {
        if(walking == true)
        {
            ai.destination = dest;
            ai.speed = 3;
        }

        if(running == true)
        {
            dest = playerTransform.position;
            ai.destination = dest;
            ai.speed = 9;
        }

        if(idle == true)
        {
            ai.speed = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            idle = false;
            walking = false;
            running = true;

            aiAnimator.ResetTrigger("idle");
            aiAnimator.ResetTrigger("walk");
            aiAnimator.SetTrigger("run");

            StopCoroutine("nextDestination");
            StopCoroutine("chase");
            StartCoroutine("chase");
        }

        if(other.CompareTag("destination"))
        {
            if(running == false)
            {
                idle = true;
                walking = false;
                aiAnimator.SetTrigger("idle");
                aiAnimator.ResetTrigger("walk");
                StartCoroutine("nextDestination");
            }
        }
    }

    IEnumerator nextDestination()
    {
        yield return new WaitForSeconds(idleDuration);
        idle = false;
        walking = true;
        aiAnimator.ResetTrigger("idle");
        aiAnimator.SetTrigger("walk");

        randNum = Random.Range(0, 8);
        if(randNum == 0)
        {
            dest = randDest1.position;
        }

        if(randNum == 1)
        {
            dest = randDest2.position;
        }

        if(randNum == 2)
        {
            dest = randDest3.position;
        }

        if(randNum == 3)
        {
            dest = randDest4.position;
        }

        if(randNum == 4)
        {
            dest = randDest5.position;
        }

        if(randNum == 5)
        {
            dest = randDest6.position;
        }

        if(randNum == 6)
        {
            dest = randDest7.position;
        }

        if(randNum == 7)
        {
            dest = randDest8.position;
        }
    }

    IEnumerator chase()
    {
        yield return new WaitForSeconds(chaseDuration);
        walking = true;
        running = false;
        aiAnimator.ResetTrigger("idle");
        aiAnimator.SetTrigger("walk");
        aiAnimator.ResetTrigger("run");

        randNum = Random.Range(0, 8);
        if(randNum == 0)
        {
            dest = randDest1.position;
        }

        if(randNum == 1)
        {
            dest = randDest2.position;
        }

        if(randNum == 2)
        {
            dest = randDest3.position;
        }

        if(randNum == 3)
        {
            dest = randDest4.position;
        }

        if(randNum == 4)
        {
            dest = randDest5.position;
        }

        if(randNum == 5)
        {
            dest = randDest6.position;
        }

        if(randNum == 6)
        {
            dest = randDest7.position;
        }

        if(randNum == 7)
        {
            dest = randDest8.position;
        }
    }
}
