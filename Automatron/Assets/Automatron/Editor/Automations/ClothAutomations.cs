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

		public override IEnumerator Execute() {
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

		public override IEnumerator Execute() {
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

	[Automation( "Cloth/Get Enable Continuous Collision" )]
	class ClothenableContinuousCollisionGet12 : ConditionalAutomation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableContinuousCollision;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Cloth/Set Enable Continuous Collision" )]
	class ClothenableContinuousCollisionSet12 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableContinuousCollision = Value;
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

	[Automation( "Cloth/Get Enable Tethers" )]
	class ClothenableTethersGet14 : ConditionalAutomation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableTethers;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Cloth/Set Enable Tethers" )]
	class ClothenableTethersSet14 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableTethers = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Coefficients" )]
	class ClothcoefficientsGet15 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.ClothSkinningCoefficient[] Result;

		public override IEnumerator Execute() {
			Result = Instance.coefficients;
			yield break;
		}

	}

	[Automation( "Cloth/Set Coefficients" )]
	class ClothcoefficientsSet15 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.ClothSkinningCoefficient[] Value;

		public override IEnumerator Execute() {
			Instance.coefficients = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get World Velocity Scale" )]
	class ClothworldVelocityScaleGet16 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.worldVelocityScale;
			yield break;
		}

	}

	[Automation( "Cloth/Set World Velocity Scale" )]
	class ClothworldVelocityScaleSet16 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.worldVelocityScale = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get World Acceleration Scale" )]
	class ClothworldAccelerationScaleGet17 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.worldAccelerationScale;
			yield break;
		}

	}

	[Automation( "Cloth/Set World Acceleration Scale" )]
	class ClothworldAccelerationScaleSet17 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.worldAccelerationScale = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Cloth Solver Frequency" )]
	class ClothclothSolverFrequencyGet18 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.clothSolverFrequency;
			yield break;
		}

	}

	[Automation( "Cloth/Set Cloth Solver Frequency" )]
	class ClothclothSolverFrequencySet18 : Automation {

		public UnityEngine.Cloth Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.clothSolverFrequency = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Capsule Colliders" )]
	class ClothcapsuleCollidersGet19 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.CapsuleCollider[] Result;

		public override IEnumerator Execute() {
			Result = Instance.capsuleColliders;
			yield break;
		}

	}

	[Automation( "Cloth/Set Capsule Colliders" )]
	class ClothcapsuleCollidersSet19 : Automation {

		public UnityEngine.Cloth Instance;
		public UnityEngine.CapsuleCollider[] Value;

		public override IEnumerator Execute() {
			Instance.capsuleColliders = Value;
			yield break;
		}

	}

	[Automation( "Cloth/Get Sphere Colliders" )]
	class ClothsphereCollidersGet20 : Automation {

		public UnityEngine.Cloth Instance;
		[ReadOnly]
		public UnityEngine.ClothSphereColliderPair[] Result;

		public override IEnumerator Execute() {
			Result = Instance.sphereColliders;
			yield break;
		}

	}

	[Automation( "Cloth/Set Sphere Colliders" )]
	class ClothsphereCollidersSet20 : Automation {

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
