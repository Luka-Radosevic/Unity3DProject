using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool isRunning = animator.GetBool("isRunning");
        bool isJumping = animator.GetBool("isJumping");
        bool isFalling = animator.GetBool("isFalling");
        bool walk = Input.GetKey("w") || Input.GetKey("s");
        bool run = Input.GetKey("left shift");
        bool jump = Input.GetKey("space");
        
        if(!isWalking && walk){
            animator.SetBool("isWalking", true);
        }

        if(isWalking && !walk){
            animator.SetBool("isWalking", false);
        }

        if(!isRunning && (walk && run))
        {
            animator.SetBool("isRunning", true);
        }

        if(isRunning && (!walk || !run))
        {
            animator.SetBool("isRunning", false);
        }

        if(jump && !walk && !run)
        {
            animator.SetBool("isJumping", true);
            isJumping = true;
        }

        if(jump && !isJumping){
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", true);
            isJumping = false;
            isFalling = true;
        }
    }
}
