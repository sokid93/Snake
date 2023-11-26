using UnityEngine;

namespace Player {
	public abstract class BodyPart : MonoBehaviour {
		
		[Header("[References]")]
		private Rigidbody2D rb;
		protected Vector2 realPosition;
		private Vector2 previousPosition;
		private BodyPart nextBodyPart;

		protected void GetReferences() {
			rb.GetComponent<Rigidbody2D>();
		}

		protected void AddBodyPart(BodyPart other) {
			if (nextBodyPart == null) {
				other.MovePosition(previousPosition);
				nextBodyPart = other;
			} else {
				nextBodyPart.AddBodyPart(other);
			}
		}

		protected void MovePosition(Vector2 newPosition) {
			if(nextBodyPart != null)
				nextBodyPart.MovePosition(rb.position);

			previousPosition = newPosition;
			rb.position = newPosition;
		}
	}
}