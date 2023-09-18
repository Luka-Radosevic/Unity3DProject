using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public GameObject monster;
    public Collider collision;
    public AudioSource spawnSound;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            monster.SetActive(true);
            collision.enabled = false;
            spawnSound.Play();
        }
    }
}
