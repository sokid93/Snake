using UnityEngine;

namespace Player {
	public abstract class BodyPart : MonoBehaviour {
		
		[Header("[References]")]
		private Rigidbody2D rb;
		protected Vector2 realPosition;
		private Vector2Int currentPosition;
		private Vector2Int previousPosition;
		private BodyPart nextBodyPart;

		protected void GetReferences() {
			rb = GetComponent<Rigidbody2D>();
		}

		protected void AddBodyPart(BodyPart other) {
			if (nextBodyPart == null) {
				other.MovePosition(previousPosition);
				nextBodyPart = other;
			} else {
				nextBodyPart.AddBodyPart(other);
			}
		}

		protected void MovePosition(Vector2Int newPosition) {
			if (currentPosition == newPosition) return;
			
			if(nextBodyPart != null)
				nextBodyPart.MovePosition(previousPosition);
            
			previousPosition = currentPosition;
			rb.position = currentPosition = newPosition;
		}
	}
}