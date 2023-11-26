using UnityEngine;

namespace Player {
	public abstract class BodyPart : MonoBehaviour {
		
		[Header("[References]")]
		private Rigidbody2D rb;
		protected Vector2 realPosition;
		private Vector2Int currentPosition;
		private BodyPart nextBodyPart;

		protected void GetReferences() {
			rb = GetComponent<Rigidbody2D>();
		}

		protected void Initialize(Vector2Int position) {
			rb.position = currentPosition = position;
		}

		protected void AddBodyPart(BodyPart other) {
			if (nextBodyPart == null) {
				other.Initialize(currentPosition);
				nextBodyPart = other;
			} else {
				nextBodyPart.AddBodyPart(other);
			}
		}

		protected void MovePosition(Vector2Int newPosition) {
			if (currentPosition == newPosition) return;
			
			if(nextBodyPart != null)
				nextBodyPart.MovePosition(currentPosition);

			rb.position = currentPosition = newPosition;
		}
	}
}