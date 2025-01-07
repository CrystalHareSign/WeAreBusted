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
        bool isWalking = animator.GetBool("isWalking");
        bool isRunning = animator.GetBool("isRunning");
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool backPressed = Input.GetKey(KeyCode.S);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        //Idle animation to walk animation
        if (!isWalking && (forwardPressed || backPressed || leftPressed || rightPressed))
        {
            animator.SetBool("isWalking", true);
        }

        //Walk animation to idle animation
        if (isWalking && !forwardPressed && !backPressed && !leftPressed && !rightPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (isWalking && runPressed)
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && !runPressed)
        {
            animator.SetBool("isRunning", false);
        }
    }
}
