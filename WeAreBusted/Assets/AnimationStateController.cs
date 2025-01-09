using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalkingW = animator.GetBool("isWalkingW");
        bool isWalkingS = animator.GetBool("isWalkingS");
        bool isWalkingA = animator.GetBool("isWalkingA");
        bool isWalkingD = animator.GetBool("isWalkingD");
        bool isWalkingWA = animator.GetBool("isWalkingWA");

        bool isRunning = animator.GetBool("isRunning");

        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool backPressed = Input.GetKey(KeyCode.S);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool forwardLeftPressed = Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A);

        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        //Walking forward animation
        if (!isWalkingW && (forwardPressed))
        {
            animator.SetBool("isWalkingW", true);
        }

        if (isWalkingW && !forwardPressed)
        {
            animator.SetBool("isWalkingW", false);
        }


        //Walking backward animation
        if (!isWalkingS && (backPressed))
        {
            animator.SetBool("isWalkingS", true);
        }
        if (isWalkingS && !backPressed)
        {
            animator.SetBool("isWalkingS", false);
        }

        //Walking left animation
        if (!isWalkingA && (leftPressed))
        {
            animator.SetBool("isWalkingA", true);
        }
        if (isWalkingA && !leftPressed)
        {
            animator.SetBool("isWalkingA", false);
        }

        //Walking right animation
        if (!isWalkingD && (rightPressed))
        {
            animator.SetBool("isWalkingD", true);
        }
        if (isWalkingD && !rightPressed)
        {
            animator.SetBool("isWalkingD", false);
        }

        //Walking forward left animation
        if (!isWalkingWA && forwardLeftPressed)
        {
            animator.SetBool("isWalkingWA", true);
        }
        if (isWalkingWA && !forwardLeftPressed)
        {
            animator.SetBool("isWalkingWA", false); //Stop walking forward left animation
        }
        
        //if (isWalkingW && !isWalkingA)
        //{
        //    animator.SetBool("isWalkingWA", false);
        //}

        //Walking to Run animation
        if (isWalkingW && runPressed)
        {
            animator.SetBool("isRunning", true);
        }

        //Stop runing animation
        if (isRunning && !runPressed)
        {
            animator.SetBool("isRunning", false);
        }
    }
}
