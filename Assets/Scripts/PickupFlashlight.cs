using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFlashlight : MonoBehaviour
{
    public GameObject text, handLamp, pickupSound;
    public bool interactable;

    void Start()
    {
        handLamp.SetActive(false);
        pickupSound.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            text.SetActive(true);
            interactable = true;

            if(Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                handLamp.SetActive(true);
                playPickupSound();
                text.SetActive(false);
                interactable = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            text.SetActive(false);
            interactable = false;
            
        }
    }

    void playPickupSound(){
        pickupSound.SetActive(true);
    }
}
