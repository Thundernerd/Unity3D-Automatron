using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Configurable Joint/Get Secondary Axis" )]
	class ConfigurableJointsecondaryAxisGet0 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryAxis;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Secondary Axis" )]
	class ConfigurableJointsecondaryAxisSet0 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.secondaryAxis = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get X Motion" )]
	class ConfigurableJointxMotionGet1 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.ConfigurableJointMotion Result;

		public override IEnumerator Execute() {
			Result = Instance.xMotion;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set X Motion" )]
	class ConfigurableJointxMotionSet1 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.ConfigurableJointMotion Value;

		public override IEnumerator Execute() {
			Instance.xMotion = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Y Motion" )]
	class ConfigurableJointyMotionGet2 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.ConfigurableJointMotion Result;

		public override IEnumerator Execute() {
			Result = Instance.yMotion;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Y Motion" )]
	class ConfigurableJointyMotionSet2 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.ConfigurableJointMotion Value;

		public override IEnumerator Execute() {
			Instance.yMotion = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Z Motion" )]
	class ConfigurableJointzMotionGet3 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.ConfigurableJointMotion Result;

		public override IEnumerator Execute() {
			Result = Instance.zMotion;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Z Motion" )]
	class ConfigurableJointzMotionSet3 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.ConfigurableJointMotion Value;

		public override IEnumerator Execute() {
			Instance.zMotion = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular X Motion" )]
	class ConfigurableJointangularXMotionGet4 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.ConfigurableJointMotion Result;

		public override IEnumerator Execute() {
			Result = Instance.angularXMotion;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular X Motion" )]
	class ConfigurableJointangularXMotionSet4 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.ConfigurableJointMotion Value;

		public override IEnumerator Execute() {
			Instance.angularXMotion = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular Y Motion" )]
	class ConfigurableJointangularYMotionGet5 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.ConfigurableJointMotion Result;

		public override IEnumerator Execute() {
			Result = Instance.angularYMotion;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular Y Motion" )]
	class ConfigurableJointangularYMotionSet5 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.ConfigurableJointMotion Value;

		public override IEnumerator Execute() {
			Instance.angularYMotion = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular Z Motion" )]
	class ConfigurableJointangularZMotionGet6 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.ConfigurableJointMotion Result;

		public override IEnumerator Execute() {
			Result = Instance.angularZMotion;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular Z Motion" )]
	class ConfigurableJointangularZMotionSet6 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.ConfigurableJointMotion Value;

		public override IEnumerator Execute() {
			Instance.angularZMotion = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Linear Limit Spring" )]
	class ConfigurableJointlinearLimitSpringGet7 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimitSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.linearLimitSpring;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Linear Limit Spring" )]
	class ConfigurableJointlinearLimitSpringSet7 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimitSpring Value;

		public override IEnumerator Execute() {
			Instance.linearLimitSpring = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular X Limit Spring" )]
	class ConfigurableJointangularXLimitSpringGet8 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimitSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.angularXLimitSpring;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular X Limit Spring" )]
	class ConfigurableJointangularXLimitSpringSet8 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimitSpring Value;

		public override IEnumerator Execute() {
			Instance.angularXLimitSpring = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular YZ Limit Spring" )]
	class ConfigurableJointangularYZLimitSpringGet9 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimitSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.angularYZLimitSpring;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular YZ Limit Spring" )]
	class ConfigurableJointangularYZLimitSpringSet9 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimitSpring Value;

		public override IEnumerator Execute() {
			Instance.angularYZLimitSpring = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Linear Limit" )]
	class ConfigurableJointlinearLimitGet10 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.linearLimit;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Linear Limit" )]
	class ConfigurableJointlinearLimitSet10 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.linearLimit = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Low Angular X Limit" )]
	class ConfigurableJointlowAngularXLimitGet11 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.lowAngularXLimit;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Low Angular X Limit" )]
	class ConfigurableJointlowAngularXLimitSet11 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.lowAngularXLimit = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get High Angular X Limit" )]
	class ConfigurableJointhighAngularXLimitGet12 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.highAngularXLimit;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set High Angular X Limit" )]
	class ConfigurableJointhighAngularXLimitSet12 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.highAngularXLimit = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular Y Limit" )]
	class ConfigurableJointangularYLimitGet13 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.angularYLimit;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular Y Limit" )]
	class ConfigurableJointangularYLimitSet13 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.angularYLimit = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular Z Limit" )]
	class ConfigurableJointangularZLimitGet14 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.angularZLimit;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular Z Limit" )]
	class ConfigurableJointangularZLimitSet14 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.angularZLimit = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Target Position" )]
	class ConfigurableJointtargetPositionGet15 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetPosition;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Target Position" )]
	class ConfigurableJointtargetPositionSet15 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.targetPosition = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Target Velocity" )]
	class ConfigurableJointtargetVelocityGet16 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetVelocity;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Target Velocity" )]
	class ConfigurableJointtargetVelocitySet16 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.targetVelocity = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get X Drive" )]
	class ConfigurableJointxDriveGet17 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointDrive Result;

		public override IEnumerator Execute() {
			Result = Instance.xDrive;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set X Drive" )]
	class ConfigurableJointxDriveSet17 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointDrive Value;

		public override IEnumerator Execute() {
			Instance.xDrive = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Y Drive" )]
	class ConfigurableJointyDriveGet18 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointDrive Result;

		public override IEnumerator Execute() {
			Result = Instance.yDrive;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Y Drive" )]
	class ConfigurableJointyDriveSet18 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointDrive Value;

		public override IEnumerator Execute() {
			Instance.yDrive = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Z Drive" )]
	class ConfigurableJointzDriveGet19 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointDrive Result;

		public override IEnumerator Execute() {
			Result = Instance.zDrive;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Z Drive" )]
	class ConfigurableJointzDriveSet19 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointDrive Value;

		public override IEnumerator Execute() {
			Instance.zDrive = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Target Rotation" )]
	class ConfigurableJointtargetRotationGet20 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.targetRotation;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Target Rotation" )]
	class ConfigurableJointtargetRotationSet20 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.targetRotation = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Target Angular Velocity" )]
	class ConfigurableJointtargetAngularVelocityGet21 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetAngularVelocity;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Target Angular Velocity" )]
	class ConfigurableJointtargetAngularVelocitySet21 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.targetAngularVelocity = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Rotation Drive Mode" )]
	class ConfigurableJointrotationDriveModeGet22 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.RotationDriveMode Result;

		public override IEnumerator Execute() {
			Result = Instance.rotationDriveMode;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Rotation Drive Mode" )]
	class ConfigurableJointrotationDriveModeSet22 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.RotationDriveMode Value;

		public override IEnumerator Execute() {
			Instance.rotationDriveMode = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular X Drive" )]
	class ConfigurableJointangularXDriveGet23 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointDrive Result;

		public override IEnumerator Execute() {
			Result = Instance.angularXDrive;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular X Drive" )]
	class ConfigurableJointangularXDriveSet23 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointDrive Value;

		public override IEnumerator Execute() {
			Instance.angularXDrive = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Angular YZ Drive" )]
	class ConfigurableJointangularYZDriveGet24 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointDrive Result;

		public override IEnumerator Execute() {
			Result = Instance.angularYZDrive;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Angular YZ Drive" )]
	class ConfigurableJointangularYZDriveSet24 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointDrive Value;

		public override IEnumerator Execute() {
			Instance.angularYZDrive = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Slerp Drive" )]
	class ConfigurableJointslerpDriveGet25 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointDrive Result;

		public override IEnumerator Execute() {
			Result = Instance.slerpDrive;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Slerp Drive" )]
	class ConfigurableJointslerpDriveSet25 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointDrive Value;

		public override IEnumerator Execute() {
			Instance.slerpDrive = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Projection Mode" )]
	class ConfigurableJointprojectionModeGet26 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public UnityEngine.JointProjectionMode Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionMode;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Projection Mode" )]
	class ConfigurableJointprojectionModeSet26 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public UnityEngine.JointProjectionMode Value;

		public override IEnumerator Execute() {
			Instance.projectionMode = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Projection Distance" )]
	class ConfigurableJointprojectionDistanceGet27 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionDistance;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Projection Distance" )]
	class ConfigurableJointprojectionDistanceSet27 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.projectionDistance = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Projection Angle" )]
	class ConfigurableJointprojectionAngleGet28 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionAngle;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Set Projection Angle" )]
	class ConfigurableJointprojectionAngleSet28 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.projectionAngle = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Configured In World Space" )]
	class ConfigurableJointconfiguredInWorldSpaceGet29 : ConditionalAutomation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.configuredInWorldSpace;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Configurable Joint/Set Configured In World Space" )]
	class ConfigurableJointconfiguredInWorldSpaceSet29 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.configuredInWorldSpace = Value;
			yield break;
		}

	}

	[Automation( "Configurable Joint/Get Swap Bodies" )]
	class ConfigurableJointswapBodiesGet30 : ConditionalAutomation {

		public UnityEngine.ConfigurableJoint Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.swapBodies;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Configurable Joint/Set Swap Bodies" )]
	class ConfigurableJointswapBodiesSet30 : Automation {

		public UnityEngine.ConfigurableJoint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.swapBodies = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
