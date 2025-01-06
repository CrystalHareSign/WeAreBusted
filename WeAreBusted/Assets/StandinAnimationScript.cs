using UnityEngine;

public class StandinAnimationScript : StateMachineBehaviour
{


    public class PlayerMovementScript : MonoBehaviour


    {
        public float moveSpeed = 5.0f;
        public Transform groundCheck;
        private Animator animator;
        private CharacterController characterController;

        void Start()
        {

            animator = GetComponent<Animator>();
            characterController = GetComponent<CharacterController>();
          
        }

        void Update()
        {
            float move = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(0, 0, move * moveSpeed * Time.deltaTime);
            characterController.Move(movement);
            animator.SetFloat("Speed", Mathf.Abs(move));

            if (groundCheck != null)
            {
                Vector3 groundPosition = groundCheck.position;
            }
        }
    }
}
