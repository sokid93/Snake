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
        [SerializeField] private Vector2 currentMovementDirection;


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

            if(Check_ValidInput(newDirectionInput))
                currentMovementDirection = newDirectionInput;
        }

        private bool Check_ValidInput(Vector2 newDirectionInput)
        {
            bool isValid = false;

            if (newDirectionInput != Vector2.zero)
            {
                isValid = true;
            }

            return isValid;
        }


       

        private void MoveForward()
        {
            playerRb.velocity = currentMovementDirection.normalized * movementSpeed * Time.deltaTime;
        }
    }
}

