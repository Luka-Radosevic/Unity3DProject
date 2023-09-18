using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject light;
    public AudioSource lightOn, lightOff;
    public bool toggle;

    void Start()
    {
        toggle = true;
        
        if(toggle == false)
        {
            light.SetActive(false);
        }
        if(toggle == true)
        {
            light.SetActive(true);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            toggle = !toggle;
            if(toggle == false)
            {
                light.SetActive(false);
                lightOn.Play();
            }

            if(toggle == true)
            {
                light.SetActive(true);
                lightOff.Play();
            }
        }
    }
}
