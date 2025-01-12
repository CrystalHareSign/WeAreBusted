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
        //Basic bools for movement
        bool isWalkingW = animator.GetBool("isWalkingW");
        bool isWalkingS = animator.GetBool("isWalkingS");
        bool isWalkingA = animator.GetBool("isWalkingA");
        bool isWalkingD = animator.GetBool("isWalkingD");

        //Running, crouching and jumping bools
        bool isRunning = animator.GetBool("isRunning");

        bool isJumpingIdle = animator.GetBool("isJumpingIdle");
        bool isJumpingForward = animator.GetBool("isJumpingForward");

        //Key Inputs for movement
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool backPressed = Input.GetKey(KeyCode.S);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool jumpingPressed = Input.GetKey(KeyCode.Space);

        //Additional bools for movement
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

        //Jumping from idle
        if (!isJumpingIdle && jumpingPressed)
        {
            animator.SetBool("isJumpingIdle", true);
        }
        else
        {
            animator.SetBool("isJumpingIdle", false);
        }

        //Jumping forward
        if (isWalkingW && jumpingPressed)
        {
            animator.SetBool("isJumpingForward", true);
        }
        if (isJumpingForward && !jumpingPressed)
        {
            animator.SetBool("isJumpingForward", false);
        }
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
