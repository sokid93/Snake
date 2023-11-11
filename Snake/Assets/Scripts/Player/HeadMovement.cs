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
        [SerializeField] private Vector2 movementDirectionInput;


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

            if(horizontalInput != 0 || verticalInput != 0)
                movementDirectionInput = new Vector2(horizontalInput, verticalInput);
        }

        private void MoveForward()
        {
            playerRb.velocity = movementDirectionInput.normalized * movementSpeed * Time.deltaTime;
        }
    }
}

