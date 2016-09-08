using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Character Controller/Get Is Grounded" )]
	class CharacterControllerisGroundedGet0 : ConditionalAutomation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isGrounded;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Character Controller/Get Velocity" )]
	class CharacterControllervelocityGet1 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Collision Flags" )]
	class CharacterControllercollisionFlagsGet2 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public UnityEngine.CollisionFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.collisionFlags;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Radius" )]
	class CharacterControllerradiusGet3 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Character Controller/Set Radius" )]
	class CharacterControllerradiusSet3 : Automation {

		public UnityEngine.CharacterController Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Height" )]
	class CharacterControllerheightGet4 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Character Controller/Set Height" )]
	class CharacterControllerheightSet4 : Automation {

		public UnityEngine.CharacterController Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Center" )]
	class CharacterControllercenterGet5 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Character Controller/Set Center" )]
	class CharacterControllercenterSet5 : Automation {

		public UnityEngine.CharacterController Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Slope Limit" )]
	class CharacterControllerslopeLimitGet6 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.slopeLimit;
			yield break;
		}

	}

	[Automation( "Character Controller/Set Slope Limit" )]
	class CharacterControllerslopeLimitSet6 : Automation {

		public UnityEngine.CharacterController Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.slopeLimit = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Step Offset" )]
	class CharacterControllerstepOffsetGet7 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stepOffset;
			yield break;
		}

	}

	[Automation( "Character Controller/Set Step Offset" )]
	class CharacterControllerstepOffsetSet7 : Automation {

		public UnityEngine.CharacterController Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stepOffset = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Skin Width" )]
	class CharacterControllerskinWidthGet8 : Automation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.skinWidth;
			yield break;
		}

	}

	[Automation( "Character Controller/Set Skin Width" )]
	class CharacterControllerskinWidthSet8 : Automation {

		public UnityEngine.CharacterController Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.skinWidth = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Get Detect Collisions" )]
	class CharacterControllerdetectCollisionsGet9 : ConditionalAutomation {

		public UnityEngine.CharacterController Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.detectCollisions;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Character Controller/Set Detect Collisions" )]
	class CharacterControllerdetectCollisionsSet9 : Automation {

		public UnityEngine.CharacterController Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.detectCollisions = Value;
			yield break;
		}

	}

	[Automation( "Character Controller/Simple Move" )]
	class CharacterControllerSimpleMove0 : ConditionalAutomation {

		public UnityEngine.CharacterController Instance;
		public UnityEngine.Vector3 speed;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.SimpleMove(speed);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Character Controller/Move" )]
	class CharacterControllerMove1 : Automation {

		public UnityEngine.CharacterController Instance;
		public UnityEngine.Vector3 motion;
		[ReadOnly]
		public UnityEngine.CollisionFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.Move(motion);
			yield break;
		}

	}


#pragma warning restore 0649
}
