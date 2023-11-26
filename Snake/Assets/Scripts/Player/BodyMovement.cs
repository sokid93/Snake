using UnityEngine;

namespace Player {
	public class BodyMovement : BodyPart {
		
		private void Awake()
		{
			GetReferences();
		}
		
		public override void AddBodyPart(BodyPart other) {
			if(nextBodyPart == null)
				nextBodyPart = other;
			else
				nextBodyPart.AddBodyPart(other);
		}
	}
}