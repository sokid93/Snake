using UnityEngine;

namespace Player {
	public class BodyMovement : BodyPart {
		
		private void Awake()
		{
			GetReferences();
		}
		
		public override void AddBodyPart(BodyPart other) {
			if (nextBodyPart == null) {
				other.MovePosition(previousPosition);
				nextBodyPart = other;
			}else
				nextBodyPart.AddBodyPart(other);
		}
	}
}