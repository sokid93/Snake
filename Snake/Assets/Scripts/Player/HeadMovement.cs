using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class HeadMovement : BodyPart
    {
        [Header("[References]")]
        [SerializeField] private BodyPart bodyPartPrefab;
        
        [Header("[Configuration]")]
        [SerializeField] private float movementSpeed;

        [Header("[Values]")]
        public Vector2 currentMovementDirection;


        private void Awake()
        {
            GetReferences();
            Initialize(Vector2Int.RoundToInt(transform.position));
        }

        private void Update()
        {
            Read_MovementInput();
            MoveForward();
            BodyPartCreationTest();
        }

        private void Read_MovementInput()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            Vector2 newDirectionInput = new Vector2(horizontalInput, verticalInput);

            if(Check_ValidDirection(newDirectionInput))
                currentMovementDirection = newDirectionInput;
        }

        void BodyPartCreationTest() {
            if (!Input.GetKeyDown(KeyCode.Space)) return;
            
            BodyPart newBodyPart = Instantiate(bodyPartPrefab);
            AddBodyPart(newBodyPart);
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

        private void MoveForward() {
            realPosition += currentMovementDirection * movementSpeed * Time.deltaTime;
            MovePosition(Vector2Int.RoundToInt(realPosition));
        }
    }
}

