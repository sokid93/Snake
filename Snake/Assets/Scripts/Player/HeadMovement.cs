using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class HeadMovement : MonoBehaviour
    {
        [Header("[Configuration]")]
        [SerializeField] private float movementSpeed;

        [Header("[Values]")]
        [SerializeField] private Vector2 movementDirectionInput;


        private void Update()
        {
            Read_MovementInput();
        }

        private void Read_MovementInput()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            movementDirectionInput = new Vector2(horizontalInput, verticalInput);
        }
    }
}

