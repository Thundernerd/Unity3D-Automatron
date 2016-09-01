using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Cloth/Get Sleep Threshold" )]
	class ClothsleepThresholdGet0 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sleepThreshold;
			yield break;
		}

	}

	[Automation( "Cloth/Set Sleep Threshold" )]
	class ClothsleepThresholdSet0 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.sleepThreshold = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Bending Stiffness" )]
	class ClothbendingStiffnessGet1 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.bendingStiffness;
			yield break;
		}

	}

	[Automation( "Cloth/Set Bending Stiffness" )]
	class ClothbendingStiffnessSet1 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.bendingStiffness = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Stretching Stiffness" )]
	class ClothstretchingStiffnessGet2 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stretchingStiffness;
			yield break;
		}

	}

	[Automation( "Cloth/Set Stretching Stiffness" )]
	class ClothstretchingStiffnessSet2 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stretchingStiffness = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Damping" )]
	class ClothdampingGet3 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.damping;
			yield break;
		}

	}

	[Automation( "Cloth/Set Damping" )]
	class ClothdampingSet3 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.damping = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get External Acceleration" )]
	class ClothexternalAccelerationGet4 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.externalAcceleration;
			yield break;
		}

	}

	[Automation( "Cloth/Set External Acceleration" )]
	class ClothexternalAccelerationSet4 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.externalAcceleration = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Random Acceleration" )]
	class ClothrandomAccelerationGet5 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.randomAcceleration;
			yield break;
		}

	}

	[Automation( "Cloth/Set Random Acceleration" )]
	class ClothrandomAccelerationSet5 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.randomAcceleration = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Use Gravity" )]
	class ClothuseGravityGet6 : ConditionalAutomation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.useGravity;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Cloth/Set Use Gravity" )]
	class ClothuseGravitySet6 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useGravity = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Enabled" )]
	class ClothenabledGet7 : ConditionalAutomation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Cloth/Set Enabled" )]
	class ClothenabledSet7 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Vertices" )]
	class ClothverticesGet8 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.Vector3[] Result;

		public override IEnumerator Execute() {
			Result = Instance.vertices;
			yield break;
		}

	}

	[Automation( "Cloth/Get Normals" )]
	class ClothnormalsGet9 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.Vector3[] Result;

		public override IEnumerator Execute() {
			Result = Instance.normals;
			yield break;
		}

	}

	[Automation( "Cloth/Get Friction" )]
	class ClothfrictionGet10 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.friction;
			yield break;
		}

	}

	[Automation( "Cloth/Set Friction" )]
	class ClothfrictionSet10 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.friction = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Collision Mass Scale" )]
	class ClothcollisionMassScaleGet11 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.collisionMassScale;
			yield break;
		}

	}

	[Automation( "Cloth/Set Collision Mass Scale" )]
	class ClothcollisionMassScaleSet11 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.collisionMassScale = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Use Continuous Collision" )]
	class ClothuseContinuousCollisionGet12 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.useContinuousCollision;
			yield break;
		}

	}

	[Automation( "Cloth/Set Use Continuous Collision" )]
	class ClothuseContinuousCollisionSet12 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.useContinuousCollision = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Use Virtual Particles" )]
	class ClothuseVirtualParticlesGet13 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.useVirtualParticles;
			yield break;
		}

	}

	[Automation( "Cloth/Set Use Virtual Particles" )]
	class ClothuseVirtualParticlesSet13 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.useVirtualParticles = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Coefficients" )]
	class ClothcoefficientsGet14 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.ClothSkinningCoefficient[] Result;

		public override IEnumerator Execute() {
			Result = Instance.coefficients;
			yield break;
		}

	}

	[Automation( "Cloth/Set Coefficients" )]
	class ClothcoefficientsSet14 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.ClothSkinningCoefficient[] Value;

		public override IEnumerator Execute() {
			Instance.coefficients = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get World Velocity Scale" )]
	class ClothworldVelocityScaleGet15 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.worldVelocityScale;
			yield break;
		}

	}

	[Automation( "Cloth/Set World Velocity Scale" )]
	class ClothworldVelocityScaleSet15 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.worldVelocityScale = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get World Acceleration Scale" )]
	class ClothworldAccelerationScaleGet16 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.worldAccelerationScale;
			yield break;
		}

	}

	[Automation( "Cloth/Set World Acceleration Scale" )]
	class ClothworldAccelerationScaleSet16 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.worldAccelerationScale = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Solver Frequency" )]
	class ClothsolverFrequencyGet17 : ConditionalAutomation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.solverFrequency;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Cloth/Set Solver Frequency" )]
	class ClothsolverFrequencySet17 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.solverFrequency = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Capsule Colliders" )]
	class ClothcapsuleCollidersGet18 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.CapsuleCollider[] Result;

		public override IEnumerator Execute() {
			Result = Instance.capsuleColliders;
			yield break;
		}

	}

	[Automation( "Cloth/Set Capsule Colliders" )]
	class ClothcapsuleCollidersSet18 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.CapsuleCollider[] Value;

		public override IEnumerator Execute() {
			Instance.capsuleColliders = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Sphere Colliders" )]
	class ClothsphereCollidersGet19 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.ClothSphereColliderPair[] Result;

		public override IEnumerator Execute() {
			Result = Instance.sphereColliders;
			yield break;
		}

	}

	[Automation( "Cloth/Set Sphere Colliders" )]
	class ClothsphereCollidersSet19 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.ClothSphereColliderPair[] Value;

		public override IEnumerator Execute() {
			Instance.sphereColliders = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Clear Transform Motion" )]
	class ClothClearTransformMotion0 : Automation {

		public UnityEngine.Cloth Instance;

		public override IEnumerator Execute() {
			Instance.ClearTransformMotion();
			yield break;
		}

	}

	[Automation( "Cloth/Set Enabled Fading" )]
	class ClothSetEnabledFading1 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Boolean enabled;
		public System.Single interpolationTime;

		public override IEnumerator Execute() {
			Instance.SetEnabledFading(enabled,interpolationTime);
			yield break;
		}

	}


#pragma warning restore 0649
}
