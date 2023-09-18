using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBob : MonoBehaviour
{
    public Animator cameraAnimation;
    public bool walking;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walking = true;
            cameraAnimation.ResetTrigger("idle");
            cameraAnimation.SetTrigger("walk");
            cameraAnimation.ResetTrigger("run");
            if(walking == true)
            {
                if(Input.GetKey(KeyCode.LeftShift))
                {
                    cameraAnimation.ResetTrigger("idle");
                    cameraAnimation.ResetTrigger("walk");
                    cameraAnimation.SetTrigger("run");
                }
            }
        }
        else
        {
            cameraAnimation.SetTrigger("idle");
            cameraAnimation.ResetTrigger("walk");
            cameraAnimation.ResetTrigger("run");
            walking = false;
        }
    }
}
