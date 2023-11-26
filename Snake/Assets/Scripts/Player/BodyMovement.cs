using UnityEngine;

namespace Player {
	public class BodyMovement : BodyPart {
		public override void AddBodyPart(BodyPart other) {
			if(nextBodyPart == null)
				nextBodyPart = other;
			else
				nextBodyPart.AddBodyPart(other);
		}
	}
}