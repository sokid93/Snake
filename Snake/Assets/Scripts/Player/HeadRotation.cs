using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class HeadRotation : MonoBehaviour
    {
        [Header("[References]")]
        private HeadMovement headMovement;
        [SerializeField] private GameObject headSprite;


        private void Awake()
        {
            GetReferences();
        }
        private void GetReferences()
        {
            headMovement = GetComponent<HeadMovement>();
        }


        private void Update()
        {
            Handle_HeadRotation();
        }

        private void Handle_HeadRotation()
        {
            Vector2 moveDirection = headMovement.currentMovementDirection;

            float newAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            headSprite.transform.rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
        }
    }
}

