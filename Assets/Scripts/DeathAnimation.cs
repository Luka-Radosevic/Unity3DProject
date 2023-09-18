using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAnimation : MonoBehaviour
{
    public Animator enemyAnimation;
    public GameObject player;
    public float animationTimer;
    public string sceneName;
    public AudioSource jumpscareSound;


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.SetActive(false);
            enemyAnimation.SetTrigger("jumpscare");
            jumpscareSound.Play();
            StartCoroutine(jumpscare());
        }
    }

    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(animationTimer);
        SceneManager.LoadScene(sceneName);
    }
}
