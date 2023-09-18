using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public GameObject walkingSound, runningSound;
    public AudioSource jumpingSound;
    public bool soundPlayed;

    void Start()
    {
        walkingSound.SetActive(false);
        runningSound.SetActive(false);
        soundPlayed = false;
    }

    void Update(){
        if(Input.GetKey("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            playWalkingSound();
            if(Input.GetKey(KeyCode.LeftShift))
            {
                stopWalkingSound();
                playRunningSound();
            }
            else
            {
                playWalkingSound();
            }
        }

        if(Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            stopWalkingSound();
            stopRunningSound();
        }

        if(Input.GetKeyDown(KeyCode.Space))
            {
                jumpingSound.Play();
            }

    }

    void playWalkingSound()
    {
        walkingSound.SetActive(true);
    }

    void stopWalkingSound()
    {
        walkingSound.SetActive(false);
    }

    void playRunningSound()
    {
        runningSound.SetActive(true);
    }

    void stopRunningSound()
    {
        runningSound.SetActive(false);
    }
}
