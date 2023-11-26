using UnityEngine;

namespace Player {
	public abstract class BodyPart : MonoBehaviour {
		
		[Header("[References]")]
		private Rigidbody2D rb;
		protected Vector2 realPosition;
		protected BodyPart nextBodyPart;

		protected void GetReferences() {
			rb.GetComponent<Rigidbody2D>();
		}
		
		public abstract void AddBodyPart(BodyPart other);

		protected void MovePosition(Vector2 newPosition) {
			if(nextBodyPart != null)
				nextBodyPart.MovePosition(rb.position);
			rb.position = newPosition;
		}
	}
}