using UnityEngine;

namespace Player {
	public abstract class BodyPart : MonoBehaviour {
		protected BodyPart nextBodyPart;
		protected abstract void AddBodyPart(BodyPart other);
		public abstract void MovePosition(Vector2 newPosition);
	}
}