using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class HeadMovement : MonoBehaviour
    {
        [Header("[References]")]
        private Rigidbody2D playerRb;

        [Header("[Configuration]")]
        [SerializeField] private float movementSpeed;

        [Header("[Values]")]
        public Vector2 currentMovementDirection;


        private void Awake()
        {
            GetReferences();
        }
        private void GetReferences()
        {
            playerRb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Read_MovementInput();
            MoveForward();
        }

        private void Read_MovementInput()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            Vector2 newDirectionInput = new Vector2(horizontalInput, verticalInput);

            if(Check_ValidDirection(newDirectionInput))
                currentMovementDirection = newDirectionInput;
        }


        private bool Check_ValidDirection(Vector2 newDirectionInput)
        {
            bool isValid = newDirectionInput != Vector2.zero && !Check_DiagonalInput(newDirectionInput) && !Check_ReverseDirection(newDirectionInput);

            return isValid;
        }


        private bool Check_DiagonalInput(Vector2 newDirectionInput)
        {
            bool isDiagonal = newDirectionInput.x != 0 && newDirectionInput.y != 0;

            return isDiagonal;
        }

        private bool Check_ReverseDirection(Vector2 newDirectionInput)
        {
            bool isReverseDirection = (newDirectionInput.x != 0 && currentMovementDirection.x != 0) || (newDirectionInput.y != 0 && currentMovementDirection.y != 0);

            return isReverseDirection;
        }

        private void MoveForward()
        {
            playerRb.velocity = currentMovementDirection.normalized * movementSpeed * Time.deltaTime;
        }
    }
}

